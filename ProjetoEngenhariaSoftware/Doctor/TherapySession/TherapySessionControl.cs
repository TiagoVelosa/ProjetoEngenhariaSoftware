using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware.Therapy
{
    public partial class TherapySessionControl : UserControl
    {
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private readonly Credentials _user;
        private readonly bool _show = true;
        private readonly bool _hide = false;
        private TherapySession _sessao;
        public TherapySessionControl(Credentials user)
        {
            _user = user;
            InitializeComponent();
            this.comboBoxTherapy.Items.Clear();
            LoadTherapy();
        }

        private bool CheckStartDate(DateTime horaInicio)
        {
            var hora_atual = DateTime.Now;
            var diferenca_minutos = (hora_atual - horaInicio).Minutes;
            if (diferenca_minutos > 10)
            {
                return true; //Se falta mais de 10 minutos não permite começar
            }
            else
            {
                return false;
            }
        }

        private void LoadTherapy()
        {
            var therapys = _unit.TherapySessions.GetTherapySessionsByDoctorNotDone(_user.Person.name);
            foreach (var therapy in therapys)
            {
                comboBoxTherapy.Items.Add(therapy.Title);
            }
        }
        private void ChangeBottomForm(bool show_hide)
        {
            this.button1.Visible = show_hide;
            this.label3.Visible = show_hide;
            this.label2.Visible = show_hide;
            this.label1.Visible = show_hide;
            this.listViewTreatment.Visible = show_hide;
            this.labelStart.Visible = show_hide;
            this.labelEnd.Visible = show_hide;
        }

        private void BtnLoadTherapy_Click(object sender, EventArgs e)
        {
            if (comboBoxTherapy.SelectedItem == null) return;

            var session = _unit.TherapySessions.GetTherapySessionsByTitle(comboBoxTherapy.SelectedItem.ToString());
            _sessao = session;
            var treatments = _unit.Treatments.GetTreatmentsNotDoneBySession(session);

             if (CheckStartDate(session.StartDate)) 
             { 
                 MessageBox.Show("Ainda não está na hora da reunião");
                 return;
             }
            ChangeBottomForm(_show);
            labelStart.Text = session.StartDate.ToString();
            labelEnd.Text = session.EndDate.ToString();
            foreach (var tratamento in treatments)
            {
                var itemView = new ListViewItem(tratamento.Description);
                listViewTreatment.Items.Add(itemView);
            }
        }
        private void ConcluirTratamentos(IEnumerable<Treatment> treatments)
        {
            foreach (var treat_concluido in treatments)
            {
                treat_concluido.Done = true;
                _unit.Treatments.Update(treat_concluido);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Treatment> tratamentos_concluidos = new List<Treatment>();
            foreach (ListViewItem item in this.listViewTreatment.CheckedItems)
            {
                var item_concluido = _unit.Treatments.GetTreatmentsBySessionAndDescription(_sessao, item.Text);
                tratamentos_concluidos.Add(item_concluido);
            }

            var dialog = new AddNote(tratamentos_concluidos);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _sessao.DescriptiveNote = dialog.nota;
                ConcluirTratamentos(tratamentos_concluidos);
                _unit.TherapySessions.Update(_sessao);
                _unit.Complete();
                MessageBox.Show("Sessão concluida com sucesso!");
            }
            ChangeBottomForm(_hide);
            
        }
    }
}
