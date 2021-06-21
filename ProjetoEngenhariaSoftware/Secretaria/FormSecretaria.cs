using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using ProjetoEngenhariaSoftware.Client;

namespace ProjetoEngenhariaSoftware.Secretaria
{
    public partial class FormSecretaria : Form
    {

        private readonly IUnitOfWork _unit = new UnitOfWork();
        public FormSecretaria()
        {
            InitializeComponent();
            this.clientComboBox.Items.Clear();
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = _unit.Clients.GetAll();
            
            foreach (var client in clients)
            {
                clientComboBox.Items.Add(client.name);
            }
        }

        private void LoggoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var LoginPage = new FormInicial();
            LoginPage.Show();
        }

        private void BtnLoadPescription_Click(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedItem == null) return;
            var prescriptions = _unit.Prescriptions.GetPrescriptionsByClientName(clientComboBox.SelectedItem.ToString());
            
            foreach (var prescription in prescriptions)
            {
                pescriptionCombobox.Items.Add(prescription.title);
            }
        }

        private void BtnLoadTreatments_Click(object sender, EventArgs e)
        {
            if (pescriptionCombobox.SelectedItem == null) return;
            var prescription = _unit.Prescriptions.GetPrescriptionByTitleWithDoctor(pescriptionCombobox.SelectedItem.ToString());
            var treatments = _unit.Treatments.GetTreatmentsByPrescription(prescription.ID);
            DoctorNameLabel.Text = prescription.Doctor.name;
            foreach (var treatment in treatments)
            {
                checkedListBoxTreatments.Items.Add(treatment.Name);
            }
        }




        /*private void ButtonLoadPescription_Click(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedItem == null) return;
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(clientComboBox.SelectedItem.ToString());
            var meds = _unit.Meds.GetMedsByPrescription(prescription.ID);
            var exercises = _unit.Exercises.GetExercisesByPrescription(prescription.ID);
            var treatments = _unit.Treatments.GetTreatmentsByPrescription(prescription.ID);

            foreach (var med in meds)
            {
                var itemView = new ListViewItem(med.Name);
                itemView.SubItems.Add(med.dosage.ToString());
                itemView.SubItems.Add(med.frequency);
                ListViewMeds.Items.Add(itemView);
            }

            foreach (var exercise in exercises)
            {
                var itemView = new ListViewItem(exercise.Name);
                itemView.SubItems.Add(exercise.TimeSugestion.ToString());
                ListViewExercises.Items.Add(itemView);
            }

            foreach (var treatment in treatments)
            {
                var itemView = new ListViewItem(treatment.Name);
                itemView.SubItems.Add(treatment.Done.ToString());
                itemView.SubItems.Add(treatment.Description);
                ListViewTreatments.Items.Add(itemView);
            }
        }*/
    }
}
