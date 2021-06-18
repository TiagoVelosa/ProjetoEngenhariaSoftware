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

namespace ProjetoEngenhariaSoftware.Prescription
{
    public partial class EditPrescription : UserControl
    {

        private readonly IUnitOfWork _unit = new UnitOfWork();
        private readonly Credentials _user;
        public EditPrescription(Credentials user)
        {
            InitializeComponent();
            _user = user;
            this.comboBoxPrescription.Items.Clear();
            LoadPrescriptions();

        }

        private void LoadPrescriptions()
        {
            var prescriptions = _unit.Prescriptions.GetPrescriptionsByDoctor((Doctor) _user.Person);
            foreach (var prescription in prescriptions)
            {
                comboBoxPrescription.Items.Add(prescription.title);
            }
        }

        private void BtnLoadPrescription_Click(object sender, EventArgs e)
        {
            if (comboBoxPrescription.SelectedItem == null) return;
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(comboBoxPrescription.SelectedItem.ToString());
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
                ListViewMeds.Items.Add(itemView);
            }

            foreach (var treatment in treatments)
            {
                var itemView = new ListViewItem(treatment.Name);
                itemView.SubItems.Add(treatment.Description);
                ListViewMeds.Items.Add(itemView);
            }
            
        }
    }
}
