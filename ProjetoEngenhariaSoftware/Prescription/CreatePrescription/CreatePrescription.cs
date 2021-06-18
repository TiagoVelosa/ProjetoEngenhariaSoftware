using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.Factory;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using ProjetoEngenhariaSoftware.Prescription.CreatePrescription;

namespace ProjetoEngenhariaSoftware
{
    public partial class CreatePrescription : UserControl
    {
        private DataBase.Modules.Prescription _prescription;
        private readonly IUnitOfWork _unit = new UnitOfWork();
        private readonly Credentials _user;
        public CreatePrescription(Credentials user)
        {
            InitializeComponent();
            _user = user;
            _prescription = new DataBase.Modules.Prescription();
            _unit.Prescriptions.Add(_prescription);
            _unit.Complete();
            this.comboBoxClients.Items.Clear();
            LoadClients();

        }

        private void LoadClients()
        {
            var clients = _unit.Persons.GetClients();
            foreach (var item in clients)
            {
                comboBoxClients.Items.Add(item.name).ToString();

            }
        }

        private void BtnMeds_Click(object sender, EventArgs e)
        {
            var prescription = _unit.Prescriptions.GetPrescriptionByID(_prescription.ID);
            var dialog = new CreateMed(prescription);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
                var med = (Medicamento) factory.Create(ItemFactory.Meds);
                med.dosage = Double.Parse(dialog.Dosage);
                med.frequency = dialog.Frequency;
                med.Name = dialog.Name;
                med.Prescription = prescription;
                med.Type = "Medicamento";
                

                _unit.Meds.Add(med); 
                _unit.Complete();

                var item = new ListViewItem(dialog.Name);
                item.SubItems.Add(dialog.Dosage);
                item.SubItems.Add(dialog.Frequency);
                ListViewMeds.Items.Add(item);
                

            }
        }

        private void BtnExercises_Click(object sender, EventArgs e)
        {
            var prescription = _unit.Prescriptions.GetPrescriptionByID(_prescription.ID);
            var dialog = new CreateExercise(prescription);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
               var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
               var exercise = (Exercise)factory.Create(ItemFactory.Exercise);
               exercise.Name = dialog.Name;
               exercise.TimeSugestion = TimeSpan.Parse(dialog.Date);
               exercise.Prescription = prescription;
               exercise.Type = "Exercise";

               _unit.Exercises.Add(exercise); 
               _unit.Complete();

               var item = new ListViewItem(dialog.Name);
               item.SubItems.Add(dialog.Date);
               ListViewExercises.Items.Add(item);
            }
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            var prescription = _unit.Prescriptions.GetPrescriptionByID(_prescription.ID);
            var dialog = new CreateTreatment(prescription);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
                var treatment = (Treatment) factory.Create(ItemFactory.Treatment);
                treatment.Name = dialog.Name;
                treatment.Description = dialog.Description;
                treatment.Prescription = prescription;
                treatment.Done = false;
                treatment.Type = "Treatment";

                _unit.Treatments.Add(treatment);
                _unit.Complete();

                var item = new ListViewItem(dialog.Name);
                item.SubItems.Add("Não Realizado");
                item.SubItems.Add(dialog.Description);
                ListViewTreatments.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prescription = _unit.Prescriptions.GetPrescriptionByID(_prescription.ID);
            if (string.IsNullOrEmpty(textBoxTitle.Text) || comboBoxClients.SelectedItem == null)
                MessageBox.Show("Campos incompletos!!");
            else
            {
                var name = comboBoxClients.SelectedItem.ToString();
                var client = (DataBase.Modules.Client)_unit.Persons.GetPersonByName(name);

                prescription.Doctor = (Doctor) _user.Person;
                prescription.title = textBoxTitle.Text;
                prescription.PrescriptionDate = DateTime.Now;
                prescription.Client = client;

                _unit.Complete();

                MessageBox.Show("Prescrição adicionada com Sucesso",
                    "Success", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                ResetFields();

            }

        }


        private void ResetFields() { 
            comboBoxClients.Items.Clear();
            ListViewMeds.Items.Clear();
            ListViewTreatments.Items.Clear();
            ListViewExercises.Items.Clear();
            textBoxTitle.Text = "";
            _prescription = new DataBase.Modules.Prescription();
        }
    }
}
