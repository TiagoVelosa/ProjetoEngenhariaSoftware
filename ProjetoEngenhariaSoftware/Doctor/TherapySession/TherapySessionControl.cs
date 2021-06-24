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

        private string TherapyTitle => comboBoxTherapy.SelectedItem.ToString();

        // verifica se está quase na hora de começar a sessão
        private bool CheckStartDate(DateTime horaInicio)
        {
            var hora_atual = DateTime.Now;
            var diferenca_minutos = (hora_atual - horaInicio).Minutes;
            if (diferenca_minutos > 10)
            {
                return true; //Se falta mais de 10 minutos não permite começar
            }
            return false;
        }
        //Faz query à base de dados das sessões de terapia não realizadas ainda e coloca-as na comboBox
        private void LoadTherapy()
        {
            var therapys = _unit.TherapySessions.GetTherapySessionsByDoctorNotDone(_user.Person.name);
            foreach (var therapy in therapys)
            {
                comboBoxTherapy.Items.Add(therapy.Title);
            }
        }
        //Permite alterar a visibilidade da parte inferior do form
        private void ChangeBottomForm(bool show_hide)
        {
            this.btnConcluirSessao.Visible = show_hide;
            this.label3.Visible = show_hide;
            this.label2.Visible = show_hide;
            this.label1.Visible = show_hide;
            this.listViewTreatment.Visible = show_hide;
            this.labelStart.Visible = show_hide;
            this.labelEnd.Visible = show_hide;
        }
        //Após selecionar a sessão pretendida, procura na base de dados a informação da mesma e apresenta a informação
        private void BtnLoadTherapy_Click(object sender, EventArgs e)
        {
            if (comboBoxTherapy.SelectedItem == null) return;

            var session = _unit.TherapySessions.GetTherapySessionsByTitle(TherapyTitle); 
            _sessao = session;
            var treatments = _unit.Treatments.GetTreatmentsNotDoneBySession(session);

            /*if (CheckStartDate(session.StartDate))
            {
                MessageBox.Show("Ainda não está na hora da reunião");
                return;
            }*/
            ChangeBottomForm(_show);
            labelStart.Text = session.StartDate.ToString();
            labelEnd.Text = session.EndDate.ToString();
            foreach (var tratamento in treatments)
            {
                var itemView = new ListViewItem(tratamento.Name);
                listViewTreatment.Items.Add(itemView);
            }
        }
        //Coloca os tratamentos selecionados como concluidos e faz update na base de dados
        private void ConcluirTratamentos(IEnumerable<Treatment> treatments)
        {
            foreach (var treat_concluido in treatments)
            {
                treat_concluido.Done = true;
                _unit.Treatments.Update(treat_concluido);

            }
        }

        //Conclui a sessão abrindo uma janela para atríbuir uma nota à sessão e confirmar os tratamentos concluidos
        
        private void btnConcluirSessao_Click(object sender, EventArgs e)
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
                _sessao.DescriptiveNote = dialog.Nota;
                ConcluirTratamentos(tratamentos_concluidos);
                /*foreach (var treatment in _sessao.Treatments)
                {
                    treatment.Session = null;
                }*/
                _unit.TherapySessions.Update(_sessao);
                _unit.Complete();
                MessageBox.Show("Sessão concluida com sucesso!");
            }
            ChangeBottomForm(_hide);
            comboBoxTherapy.Items.Clear();
            comboBoxTherapy.SelectedItem = null;
            LoadTherapy();

        }
    }
}
