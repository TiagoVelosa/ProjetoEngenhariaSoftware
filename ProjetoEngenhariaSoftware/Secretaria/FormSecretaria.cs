using System;
using System.Windows.Forms;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Secretaria
{
    public partial class FormSecretaria : Form
    {

        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private readonly string TimeLimitEnd = "19:00";
        private readonly string TimeLimitStart = "08:00";
        public FormSecretaria()
        {
            InitializeComponent();
            this.clientComboBox.Items.Clear();
            DayPicker.Value = DateTime.Today.Date;
            StartTime.Value = DayPicker.Value.Add(DateTime.Now.TimeOfDay.Add(new TimeSpan(0,1,0)));
            LoadClients();
        }

        private void LoggoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var LoginPage = new FormInicial();
            LoginPage.Show();
        }

        private void LoadClients()
        {
            var clients = _unit.Clients.GetAll();

            foreach (var client in clients)
            {
                clientComboBox.Items.Add(client.name);
            }
        }

        private void BtnLoadPescription_Click(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedItem == null) return;
            Reset();
            var prescriptions = _unit.Prescriptions.GetPrescriptionsByClientName(clientComboBox.SelectedItem.ToString());
            foreach (var prescription in prescriptions)
            {
                prescriptionCombobox.Items.Add(prescription.title);
            }
        }

        private void BtnLoadTreatments_Click(object sender, EventArgs e)
        {
            if (prescriptionCombobox.SelectedItem == null) return;
            Reset2();
            var prescription = _unit.Prescriptions.GetPrescriptionByTitleWithDoctor(prescriptionCombobox.SelectedItem.ToString());
            var treatments = _unit.Treatments.GetTreatmentsByPrescription(prescription.ID);
            DoctorNameLabel.Text = prescription.Doctor.name;
            foreach (var treatment in treatments)
            {
                checkedListBoxTreatments.Items.Add(treatment.Name);
            }
        }

        private void Reset()
        {
            prescriptionCombobox.SelectedItem = null;
            prescriptionCombobox.Items.Clear();
            DoctorNameLabel.Text = "";
            checkedListBoxTreatments.Items.Clear();
            listViewSelectedTreatments.Items.Clear();


        }

        private void Reset2()
        {
            DoctorNameLabel.Text = "";
            checkedListBoxTreatments.Items.Clear();
            listViewSelectedTreatments.Items.Clear();
        }


        private void BtnMoveItems_Click(object sender, EventArgs e)
        {
            listViewSelectedTreatments.Items.Clear();
            foreach (var item in checkedListBoxTreatments.SelectedItems)
            {
                listViewSelectedTreatments.Items.Add(item.ToString());
            }
        }

        private void StartTime_MouseDown(object sender, MouseEventArgs e)
        {
            StartTime.CustomFormat = "HH:mm";
        }


        private void DayPicker_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > DayPicker.Value)
            {
                MessageBox.Show("Dia Inválido!! Por favor seleciona um dia válido!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DayPicker.Value = DateTime.Today;
            }
        }

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
            EndTimeTxtBox.Text = StartTime.Value.AddHours(1).ToString("HH:mm");
            
        }

        private void BtnAddSession_Click(object sender, EventArgs e)
        {
             TimeSpan teste = StartTime.Value.TimeOfDay;
             StartTime.Value = DayPicker.Value.Date.Add(teste);
             if (clientComboBox.SelectedItem == null || prescriptionCombobox.SelectedItem == null) return;
             if (listViewSelectedTreatments.Items.Count == 0 || TitleTextBox.Text == "" || StartTime.Value.ToString() == "")
             {
                 MessageBox.Show("Campos incompletos!! Por favor preencher!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }
             else
             {
                 bool aux = true;
                 var therapysessions = _unit.TherapySessions.GetTherapySessionsByDoctor(DoctorNameLabel.Text);
                 
                 foreach (var session in therapysessions)
                 {
                     if (session.StartDate.Date == DayPicker.Value.Date)
                     { 
                         var EndTimeTxtBox_plus_day = DayPicker.Value.Date.Add(TimeSpan.Parse(EndTimeTxtBox.Text));
                         if ((session.StartDate < EndTimeTxtBox_plus_day && StartTime.Value < session.StartDate) ||
                            (session.StartDate <= StartTime.Value && EndTimeTxtBox_plus_day <= session.EndDate) ||
                            (StartTime.Value < session.EndDate && session.EndDate < EndTimeTxtBox_plus_day)
                            ){
                             MessageBox.Show("Este Médico já tem uma sessão neste intervalo de tempo!!!");
                             aux = false;
                         }
                     }

                    
                 }
                 if (aux)
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
                     
                     foreach (var treatment  in checkedListBoxTreatments.SelectedItems)
                     {
                         var addedTreatment = _unit.Treatments.GetTreatmentByName(treatment.ToString(), prescriptionCombobox.SelectedItem.ToString());
                         addedTreatment.Session = NewSession;
                         _unit.Treatments.Update(addedTreatment);

                     }

                     _unit.Complete();

                     MessageBox.Show("Sessão de Terapia agendada com sucesso!!");
                 }
             }
        }
    }
}
