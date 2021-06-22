using System;
using System.Windows.Forms;
using ClassLibraryEngSoft.Authentication.RegisterAuthentication.Prescriptions;
using ClassLibraryEngSoft.Factory;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Prescription
{
    public partial class EditPrescription : UserControl
    {

        private readonly IUnitOfWork _unit = new UnitOfWork();
        private readonly Credentials _user;
        private readonly bool show = true;
        private readonly bool hide = false;
        private ValidateItem _validator = new ValidateItem();

        public EditPrescription(Credentials user)
        {
            InitializeComponent();
            _user = user;
            HideShowForm(hide);
            this.comboBoxPrescription.Items.Clear();
            LoadPrescriptions();

        }

        private void ResetFields()
        {
            ListViewExercises.Items.Clear();
            ListViewMeds.Items.Clear();
            ListViewTreatments.Items.Clear();
            comboBoxPrescription.SelectedItem = null;
            NameTxtBox.Text = "";
            DosageTxtBox.Text = "";
            FrequencyTxtBox.Text = "";
            ExerciseNameTxtBox.Text = "";
            TreatmentNameTxtBox.Text = "";
            TimeTxtBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        private void HideShowForm(bool show_hide)
        {
            this.BtnEditPrescription.Visible = show_hide;
            this.DescriptionTextBox.Visible = show_hide;
            this.ListViewTreatments.Visible = show_hide;
            this.ListViewExercises.Visible = show_hide;
            this.ListViewMeds.Visible = show_hide;
            this.NameTxtBox.Visible = show_hide;
            this.DosageTxtBox.Visible = show_hide;
            this.FrequencyTxtBox.Visible = show_hide;
            this.ExerciseNameTxtBox.Visible = show_hide;
            this.TreatmentNameTxtBox.Visible = show_hide;
            this.TimeTxtBox.Visible = show_hide;
            this.BtnEditMed.Visible = show_hide;
            this.BtnEditExercise.Visible = show_hide;
            this.BtnEditTreatment.Visible = show_hide;
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
            HideShowForm(show);
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
                ListViewExercises.Items.Add(itemView);
            }

            foreach (var treatment in treatments)
            {
                var itemView = new ListViewItem(treatment.Name);
                itemView.SubItems.Add(treatment.Done.ToString());
                itemView.SubItems.Add(treatment.Description);
                ListViewTreatments.Items.Add(itemView);
            }
            
        }

        private void ListViewMeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NameTxtBox.Text = ListViewMeds.SelectedItems[0].Text;
                DosageTxtBox.Text = ListViewMeds.SelectedItems[0].SubItems[1].Text;
                FrequencyTxtBox.Text = ListViewMeds.SelectedItems[0].SubItems[2].Text;
            }
            catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxtBox.Text) || string.IsNullOrEmpty(DosageTxtBox.Text) || string.IsNullOrEmpty(FrequencyTxtBox.Text)) return;
            if (!_validator.IsDouble(DosageTxtBox.Text))
            {
                MessageBox.Show("Dosagem inválida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewMeds.SelectedItems[0].Text = NameTxtBox.Text;
                ListViewMeds.SelectedItems[0].SubItems[1].Text = DosageTxtBox.Text;
                ListViewMeds.SelectedItems[0].SubItems[2].Text = FrequencyTxtBox.Text;
            }

        }

        private void ListViewExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ExerciseNameTxtBox.Text = ListViewExercises.SelectedItems[0].Text;
                TimeTxtBox.Text = ListViewExercises.SelectedItems[0].SubItems[1].Text;
                
            }
            catch
            {
            }
        }

        private void ListViewTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TreatmentNameTxtBox.Text = ListViewTreatments.SelectedItems[0].Text;
                DescriptionTextBox.Text = ListViewTreatments.SelectedItems[0].SubItems[2].Text;

            }
            catch
            {
            }
        }

        private void BtnEditExercise_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExerciseNameTxtBox.Text) || string.IsNullOrEmpty(TimeTxtBox.Text) ) return;
            if (!_validator.isValidDate(TimeTxtBox.Text))
            {
                MessageBox.Show("Hora inválida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewExercises.SelectedItems[0].Text = ExerciseNameTxtBox.Text;
                ListViewExercises.SelectedItems[0].SubItems[1].Text = TimeTxtBox.Text;
            }

        }

        private void BtnEditTreatment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TreatmentNameTxtBox.Text) || string.IsNullOrEmpty(DescriptionTextBox.Text)) return;

            ListViewTreatments.SelectedItems[0].Text = TreatmentNameTxtBox.Text;
            ListViewTreatments.SelectedItems[0].SubItems[2].Text = DescriptionTextBox.Text;

            
        }

        private void BtnEditPrescription_Click(object sender, EventArgs e)
        {
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(comboBoxPrescription.SelectedItem.ToString());
            var items = _unit.Items.GetItensByPrescription(prescription.ID);
            foreach (var item in items)
            {
                _unit.Items.Remove(item);
            }
            _unit.Prescriptions.Update(prescription);
            _unit.Complete();

            var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.Types.ItemFactory);

            for (int i = 0; i < ListViewMeds.Items.Count; i++)
            {
                var med = (Medicamento)factory.Create(ItemFactory.Meds);
                med.Name = ListViewMeds.Items[i].Text;
                med.dosage = Double.Parse(ListViewMeds.Items[i].SubItems[1].Text);
                med.frequency = ListViewMeds.Items[i].SubItems[2].Text;
                med.Prescription = prescription;
                med.Type = "Medicamento";
                med.IsVisible = false;
                _unit.Meds.Add(med);
                _unit.Complete();
            }

            for (int i = 0; i < ListViewExercises.Items.Count; i++)
            {
                var exercise = (Exercise)factory.Create(ItemFactory.Exercise);
                exercise.Name = ListViewExercises.Items[i].Text;
                exercise.TimeSugestion = TimeSpan.Parse(ListViewExercises.Items[i].SubItems[1].Text);
                exercise.Type = "Exercise";
                exercise.Prescription = prescription;
                exercise.IsVisible = false;
                _unit.Exercises.Add(exercise);
                _unit.Complete();
            }

            for (int i = 0; i < ListViewTreatments.Items.Count; i++)
            {
                var treatment = (Treatment) factory.Create(ItemFactory.Treatment);
                treatment.Name = ListViewTreatments.Items[i].Text;
                treatment.Description = ListViewTreatments.Items[i].SubItems[2].Text;
                treatment.Type = "Treatment";
                treatment.Prescription = prescription;
                treatment.IsVisible = false;
                _unit.Treatments.Add(treatment);
                _unit.Complete();
            }

            MessageBox.Show("Prescrição editada com sucesso!!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            ResetFields();
            HideShowForm(hide);


        }

    }
}
