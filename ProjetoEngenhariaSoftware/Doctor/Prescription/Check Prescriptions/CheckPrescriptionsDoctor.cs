using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware.Prescription.Check_Prescriptions
{
    public partial class CheckPrescriptionsDoctor : UserControl
    {
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private readonly Credentials _user;
        public CheckPrescriptionsDoctor(Credentials user)
        {
            InitializeComponent();
            _user = user;
            Load();
        }

        private string PrescriptionTitle => comboBoxPrescription.SelectedItem.ToString();
        private void ClearLists()
        {
            this.ListMeds.Items.Clear();
            this.ListExercises.Items.Clear();
            this.ListTreatments.Items.Clear();
        }
        private void Load()
        {
            var prescriptions = _unit.Prescriptions.GetPrescriptionsExceptDoctor((Doctor)_user.Person);
            foreach (var prescription in prescriptions)
            {
                comboBoxPrescription.Items.Add(prescription.title);
            }
        }
        
        private void BtnLoadPrescription_Click(object sender, EventArgs e)
        {
            if (comboBoxPrescription.SelectedItem == null) return;
            ClearLists();
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(PrescriptionTitle);
            var exercises = _unit.Exercises.GetExercisesPublicByPrescription(prescription.ID);
            var meds = _unit.Meds.GetMedsPublicByPrescription(prescription.ID);
            var treatments = _unit.Treatments.GetTreatmentsPublicsByPrescription(prescription.ID);
            LabelClientName.Text = prescription.Client.Name;
            foreach (var exercise in exercises)
            {
                var item = new ListViewItem(exercise.Name);
                item.SubItems.Add(exercise.TimeSugestion.ToString());
                ListExercises.Items.Add(item);

            }

            foreach (var med in meds)
            {
                var item = new ListViewItem(med.Name);
                item.SubItems.Add(med.Dosage.ToString());
                item.SubItems.Add(med.Frequency);
                ListMeds.Items.Add(item);


            }

            foreach (var treatment in treatments)
            {
                var item = new ListViewItem(treatment.Name);
                if (treatment.Done)
                {
                    item.SubItems.Add("Concluído");
                }
                else
                {
                    item.SubItems.Add("Não Concluído");
                }
                item.SubItems.Add(treatment.Description);
                ListTreatments.Items.Add(item);

            }
        }
    }
}
