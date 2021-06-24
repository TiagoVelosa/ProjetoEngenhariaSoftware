using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Secretaria
{
    public partial class FormSecretaria : Form
    {

        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private readonly bool _hide = false;
        private readonly bool _show = true;
        public FormSecretaria()
        {
            InitializeComponent();
            clientComboBox.Items.Clear();
            DayPicker.Value = DateTime.Today.Date;
            StartTime.Value = DayPicker.Value.Add(DateTime.Now.TimeOfDay.Add(new TimeSpan(0,1,0)));
            LoadClients();
        }

        private void HideShow(bool hide_show)
        {
            label1.Visible = hide_show;
            prescriptionCombobox.Visible = hide_show;
            DoctorNameLabel.Visible = hide_show;
            label2.Visible = hide_show;
            listViewSelectedTreatments.Visible = hide_show;
            DayPicker.Visible = hide_show;
            StartTime.Visible = hide_show;
            EndTimeTxtBox.Visible = hide_show;
            label3.Visible = hide_show;
            label4.Visible = hide_show;
            label6.Visible = hide_show;
            label7.Visible = hide_show;
            BtnAddSession.Visible = hide_show;
            TitleTextBox.Visible = hide_show;
            BtnLoadTreatments.Visible = hide_show;
            label5.Visible = hide_show;
        }

        private void LoggoutButton_Click(object sender, EventArgs e)
        {
            Close();
            var LoginPage = new FormInicial();
            LoginPage.Show();
        }

        private void LoadClients()
        {
            var clients = _unit.Clients.GetAll();

            foreach (var client in clients)
            {
                clientComboBox.Items.Add(client.Name);
            }
        }

        
        //carrega as prescrições associadas ao client
        private void BtnLoadPescription_Click(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedItem == null) return;
            Reset();
            var prescriptions = _unit.Prescriptions.GetPrescriptionsByClientName(clientComboBox.SelectedItem.ToString());
            foreach (var prescription in prescriptions)
            {
                prescriptionCombobox.Items.Add(prescription.title);
            }
            label5.Visible = _show;
            prescriptionCombobox.Visible = _show;
            BtnLoadTreatments.Visible = _show;
        }


        //carrega todos os tratamentos associadas à prescrição selecionada
        private void BtnLoadTreatments_Click(object sender, EventArgs e)
        {

            listViewSelectedTreatments.Items.Clear();
            if (prescriptionCombobox.SelectedItem == null) return;
            var prescription = _unit.Prescriptions.GetPrescriptionByTitleWithDoctor(prescriptionCombobox.SelectedItem.ToString());
            var treatments = _unit.Treatments.GetTreatmentsByPrescription(prescription.ID);
            DoctorNameLabel.Text = prescription.Doctor.Name;
            foreach (var treatment in treatments)
            {
                listViewSelectedTreatments.Items.Add(treatment.Name);
            }
            HideShow(_show);
        }

        private void Reset()
        {
            prescriptionCombobox.SelectedItem = null;
            prescriptionCombobox.Items.Clear();
            DoctorNameLabel.Text = "";
            listViewSelectedTreatments.Items.Clear();
        }
        private void ResetConcluido()
        {
            Reset();
            TitleTextBox.Text = "";
            DayPicker.Value = DateTime.Today.Date;
            StartTime.Value = DayPicker.Value.Add(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 1, 0)));
            clientComboBox.SelectedItem = null;
            clientComboBox.Text = "";
            HideShow(_hide);

        }


        // mudou-se o formato do datetime picker para HH:mm
        private void StartTime_MouseDown(object sender, MouseEventArgs e)
        {
            StartTime.CustomFormat = "HH:mm";
        }

        // não é possível escolher um dia já passou
        private void DayPicker_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > DayPicker.Value)
            {
                MessageBox.Show("Dia Inválido!! Por favor seleciona um dia válido!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DayPicker.Value = DateTime.Today;
            }
        }


        // caso tenha sido selecionado o dia de hoje não é possível selecionar horas que já tenham passado
        private void StartTime_ValueChanged(object sender, EventArgs e)
        {
            
            if (DayPicker.Value.Date == DateTime.Today)
            {
                if (DateTime.Now > StartTime.Value)
                {
                    MessageBox.Show("Por favor escolha uma hora válida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StartTime.Value = DayPicker.Value.Date.AddHours(16);

                }
            }
            //Decidiu-se que cada sessão de terapia teria uma duração de uma hora
            //logo atualiza o valor da textbox
            EndTimeTxtBox.Text = StartTime.Value.AddHours(1).ToString("HH:mm");
            
        }


        // verica se o doctor já tem alguma sessão marcada para o horários selecionado
        private bool CheckAvailability(IEnumerable<TherapySession> therapysessions)
        {
            var EndTimeTxtBox_plus_day = DayPicker.Value.Date.Add(TimeSpan.Parse(EndTimeTxtBox.Text));
            foreach (var session in therapysessions)
            {
                if (session.StartDate.Date == DayPicker.Value.Date)
                {
                    if ((session.StartDate < EndTimeTxtBox_plus_day && StartTime.Value < session.StartDate) ||
                        (session.StartDate <= StartTime.Value && EndTimeTxtBox_plus_day <= session.EndDate) ||
                        (StartTime.Value < session.EndDate && session.EndDate < EndTimeTxtBox_plus_day)
                    )
                    {
                        MessageBox.Show("Este Médico já tem uma sessão neste intervalo de tempo!!!");
                        return false;
                    }
                }


            }

            return true;
        }


        private void BtnAddSession_Click(object sender, EventArgs e)
        {
             TimeSpan teste = StartTime.Value.TimeOfDay; // busca as horas indicadas no início 
             StartTime.Value = DayPicker.Value.Date.Add(teste); // e atualiza o valor do início com o dia + horas + minutos
             var EndTimeTxtBox_plus_day = DayPicker.Value.Date.Add(TimeSpan.Parse(EndTimeTxtBox.Text)); // atualiza também a textbox
             if (clientComboBox.SelectedItem == null || prescriptionCombobox.SelectedItem == null) return;
             if (listViewSelectedTreatments.Items.Count == 0 || TitleTextBox.Text == "" || StartTime.Value.ToString() == "")
             {
                 MessageBox.Show("Campos incompletos!! Por favor preencher!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }
             else
             {
                 var therapysessions = _unit.TherapySessions.GetTherapySessionsByDoctor(DoctorNameLabel.Text);
                 var availability = CheckAvailability(therapysessions);                 
                 if (availability)
                 {
                     
                     var doctor = _unit.Doctors.GetDoctorByName(DoctorNameLabel.Text);
                     var client = _unit.Clients.GetClientByName(clientComboBox.SelectedItem.ToString());
                     var NewSession = new TherapySession()
                     {
                         Doctor = doctor,
                         Client = client,
                         Title = TitleTextBox.Text,
                         StartDate = DayPicker.Value.Date.Add(StartTime.Value.TimeOfDay),
                         EndDate = DayPicker.Value.Date.Add(DateTime.Parse(EndTimeTxtBox.Text).TimeOfDay)
                     };
                     
                     foreach (ListViewItem treatment  in listViewSelectedTreatments.CheckedItems)
                     {
                         var addedTreatment = _unit.Treatments.GetTreatmentByName(treatment.Text, prescriptionCombobox.SelectedItem.ToString());
                         addedTreatment.Session = NewSession;
                         _unit.Treatments.Update(addedTreatment);

                     }

                     _unit.Complete();
                     MessageBox.Show("Sessão de Terapia agendada com sucesso!!");
                    ResetConcluido();
                 }
             }
        }
    }
}
