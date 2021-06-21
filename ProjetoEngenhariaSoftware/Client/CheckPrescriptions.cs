using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Client
{
    public partial class CheckPrescriptions : UserControl
    {
        private readonly IUnitOfWork _unit = new UnitOfWork();
        private readonly Credentials _user;

        public CheckPrescriptions(Credentials user)
        {
            InitializeComponent();
            _user = user;
            this.comboBoxPrescription.Items.Clear();
            LoadPrescriptions();
            
        }

        private void ClearLists()
        {
            this.ListMeds.Items.Clear();
            this.ListExercises.Items.Clear();
            this.ListTreatments.Items.Clear();
        }


        private void LoadPrescriptions()
        {
            var prescriptions = _unit.Prescriptions.GetPrescriptionsByName((DataBase.Modules.Client)_user.Person);
            foreach (var item in prescriptions)
            {
                comboBoxPrescription.Items.Add(item.title).ToString();

            }
        }

        private void BtnLoadPrescription_Click(object sender, EventArgs e)
        {
            if (comboBoxPrescription.SelectedItem == null) return;
            ClearLists();
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(comboBoxPrescription.SelectedItem.ToString());
            var meds = _unit.Meds.GetMedsByPrescription(prescription.ID);
            var exercises = _unit.Exercises.GetExercisesByPrescription(prescription.ID);
            var treatments = _unit.Treatments.GetTreatmentsByPrescription(prescription.ID);

            foreach (var exercise in exercises)
            {
                var item = new ListViewItem(exercise.Name);
                item.SubItems.Add(exercise.TimeSugestion.ToString());
                ListExercises.Items.Add(item);

            }

            foreach (var med in meds)
            {
                var item = new ListViewItem(med.Name);
                item.SubItems.Add(med.dosage.ToString());
                item.SubItems.Add(med.frequency);
                ListMeds.Items.Add(item);


            }

            foreach (var treatment in treatments)
            {
                var item = new ListViewItem(treatment.Name);
                item.SubItems.Add(treatment.Done.ToString());
                item.SubItems.Add(treatment.Description);
                ListTreatments.Items.Add(item);

            }
            
        }

        
    }
}
