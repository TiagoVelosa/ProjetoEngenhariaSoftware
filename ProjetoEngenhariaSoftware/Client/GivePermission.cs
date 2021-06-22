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

namespace ProjetoEngenhariaSoftware.Client
{
    public partial class GivePermission : UserControl
    {
        private readonly Credentials _user;
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        public GivePermission(Credentials user)
        {
            InitializeComponent();
            _user = user;
            this.comboBoxPrescriptions.Items.Clear();
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            var prescriptions = _unit.Prescriptions.GetPrescriptionsByName((DataBase.Modules.Client)_user.Person);
            foreach (var item in prescriptions)
            {
                comboBoxPrescriptions.Items.Add(item.title).ToString();

            }
        }

        private void ClearCheckBoxes()
        {
            this.checkedListBoxMeds.Items.Clear();
            this.checkedListBoxExercises.Items.Clear();
            this.checkedListBoxTreatments.Items.Clear();
        }


        private void BtnLoadPrescription_Click(object sender, EventArgs e)
        {
            if (comboBoxPrescriptions.SelectedItem == null) return;
            ClearCheckBoxes();
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(comboBoxPrescriptions.SelectedItem.ToString());
            var privateMeds = _unit.Meds.GetPrivateMeds(prescription.ID);
            var privateExercises = _unit.Exercises.GetPrivateExercises(prescription.ID);
            var privateTreatments = _unit.Treatments.GetPrivateTreatments(prescription.ID);

            CheckItems(privateMeds,privateExercises,privateTreatments);

            foreach (var item in privateMeds)
            {
                checkedListBoxMeds.Items.Add(item.Name);
            }

            foreach (var item in privateExercises)
            {
                checkedListBoxExercises.Items.Add(item.Name);
            }

            foreach (var item in privateTreatments)
            {
                checkedListBoxTreatments.Items.Add(item.Name);
            }


        }

        private void CheckItems(IEnumerable<Medicamento> meds, IEnumerable<Exercise> exercises, IEnumerable<Treatment> treatments)
        {
            if (!meds.Any())
            {
                NonExistentMeds.Visible = true;
            } 
            if(!exercises.Any())
            {
                NonExistentExercises.Visible = true;
            }
            if(!treatments.Any())
            {
                NonExistentTreatments.Visible = true;
            }
        }

        private void BtnVisability_Click(object sender, EventArgs e)
        {
            foreach (var med in checkedListBoxMeds.CheckedItems)
            {
                var MedOutdated = _unit.Meds.GetMedByName(med.ToString(), comboBoxPrescriptions.SelectedItem.ToString());
                MedOutdated.IsVisible = true;
                _unit.Meds.Update(MedOutdated);
            }

            foreach (var exercise in checkedListBoxExercises.CheckedItems)
            {
                var ExerciseOutdated = _unit.Exercises.GetExerciseByName(exercise.ToString(), comboBoxPrescriptions.SelectedItem.ToString());
                ExerciseOutdated.IsVisible = true;
                _unit.Exercises.Update(ExerciseOutdated);
            }

            foreach (var treatment in checkedListBoxTreatments.CheckedItems)
            {
                var TreatmentOutdated = _unit.Treatments.GetTreatmentByName(treatment.ToString(), comboBoxPrescriptions.SelectedItem.ToString());
                TreatmentOutdated.IsVisible = true;
                _unit.Treatments.Update(TreatmentOutdated);
            }

            _unit.Complete();
            MessageBox.Show("Atributos tornados vísíveis!!");
        }


    }
}
