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
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private readonly Credentials _user;
        private readonly IFactory _factory = SimpleFactory.Instance.CreateFactory(FactoryType.ItemFactory);

        public CreatePrescription(Credentials user)
        {
            InitializeComponent();
            _user = user;
            _prescription = new DataBase.Modules.Prescription();
            _unit.Prescriptions.Add(_prescription);
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
            
            var dialog = new CreateMed(_prescription);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var med = (Medicamento) _factory.Create(ItemFactory.Meds);
                med.dosage = Double.Parse(dialog.Dosage);
                med.frequency = dialog.Frequency;
                med.Name = dialog.Name;
                med.Prescription = _prescription;
                med.Type = "Medicamento";
                med.IsVisible = false;
                
                _unit.Meds.Add(med);

                var item = new ListViewItem(dialog.Name);
                item.SubItems.Add(dialog.Dosage);
                item.SubItems.Add(dialog.Frequency);
                ListViewMeds.Items.Add(item);
                

            }
        }

        private void BtnExercises_Click(object sender, EventArgs e)
        {
            
            var dialog = new CreateExercise(_prescription);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
              
               var exercise = (Exercise)_factory.Create(ItemFactory.Exercise);
               exercise.Name = dialog.Name;
               exercise.TimeSugestion = TimeSpan.Parse(dialog.Date);
               exercise.Prescription = _prescription;
               exercise.Type = "Exercise";
               exercise.IsVisible = false;

               _unit.Exercises.Add(exercise);

               var item = new ListViewItem(dialog.Name);
               item.SubItems.Add(dialog.Date);
               ListViewExercises.Items.Add(item);
            }
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            var dialog = new CreateTreatment(_prescription);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var treatment = (Treatment) _factory.Create(ItemFactory.Treatment);
                treatment.Name = dialog.Name;
                treatment.Description = dialog.Description;
                treatment.Prescription = _prescription;
                treatment.Done = false;
                treatment.Type = "Treatment";
                treatment.IsVisible = false;

                _unit.Treatments.Add(treatment);

                var item = new ListViewItem(dialog.Name);
                item.SubItems.Add("Não Realizado");
                item.SubItems.Add(dialog.Description);
                ListViewTreatments.Items.Add(item);
            }
        }


        // verifica se existem prescrições com títulos iguais!
        private bool CheckRepetition(IEnumerable<DataBase.Modules.Prescription> prescriptions)
        {
            foreach (var prescription in prescriptions)
            {
                if (prescription.title == textBoxTitle.Text.Trim())
                {
                    MessageBox.Show("Este cliente já tem uma prescrição com este título!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            }

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text) || comboBoxClients.SelectedItem == null)
            {
                MessageBox.Show("Campos incompletos!!");
                return;
            }

            var prescriptions = _unit.Prescriptions.GetPrescriptionsByClientName(comboBoxClients.SelectedItem.ToString());
            var availability = CheckRepetition(prescriptions);
            //bool aux = true;
            /*foreach (var prescription in prescriptions)
            {
                if (prescription.title == textBoxTitle.Text.Trim())
                {
                    MessageBox.Show("Este cliente já tem uma prescrição com este título!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    aux = false;
                    break;
                }
            }*/

            if(availability)
            {
                var client = (DataBase.Modules.Client)_unit.Persons.GetPersonByName(comboBoxClients.SelectedItem.ToString());

                _prescription.Doctor = (Doctor) _user.Person;
                _prescription.title = textBoxTitle.Text;
                _prescription.PrescriptionDate = DateTime.Now;
                _prescription.Client = client;

                _unit.Complete();

                MessageBox.Show("Prescrição adicionada com Sucesso",
                    "Success", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                //limpa os campos todos
                ResetFields();

            }

        }


        private void ResetFields() { 
            
            ListViewMeds.Items.Clear();
            ListViewTreatments.Items.Clear();
            ListViewExercises.Items.Clear();
            textBoxTitle.Text = "";
            _prescription = new DataBase.Modules.Prescription();
            comboBoxClients.SelectedItem = null;
            comboBoxClients.Items.Clear();
            LoadClients();
        }
    }
}
