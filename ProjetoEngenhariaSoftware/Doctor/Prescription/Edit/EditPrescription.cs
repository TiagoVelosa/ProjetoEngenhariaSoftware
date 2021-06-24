using System;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibraryEngSoft.Authentication.RegisterAuthentication.Prescriptions;
using ClassLibraryEngSoft.Factory;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Prescription
{
    public partial class EditPrescription : UserControl
    {

        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private readonly Credentials _user;
        private readonly bool show = true;
        private readonly bool hide = false;
        private ValidateItem _validator = new ValidateItem();
        private readonly IFactory _factory = SimpleFactory.Instance.CreateFactory(FactoryType.ItemFactory);

        public EditPrescription(Credentials user)
        {
            InitializeComponent();
            HideShowForm(hide);
            _user = user;
            this.comboBoxPrescription.Items.Clear();
            LoadPrescriptions();

        }

        private string PrescriptionTitle => comboBoxPrescription.SelectedItem.ToString();
        public string MedName
        {
            get => NameTxtBox.Text;
            set => NameTxtBox.Text = value;
        }

        public string MedDosage
        {
            get => DosageTxtBox.Text;
            set => DosageTxtBox.Text = value;
        }

        public string MedFrequency
        {
            get => FrequencyTxtBox.Text;
            set => FrequencyTxtBox.Text = value;
        }

        public string ExerciseName
        {
            get => ExerciseNameTxtBox.Text;
            set => ExerciseNameTxtBox.Text = value;
        }

        public string ExerciseHour
        {
            get => TimeTxtBox.Text;
            set => TimeTxtBox.Text = value;
        }

        public string TreatmentName
        {
            get => TreatmentNameTxtBox.Text;
            set => TreatmentNameTxtBox.Text = value;
        }

        public string TreatmentDescription
        {
            get => DescriptionTextBox.Text;
            set => DescriptionTextBox.Text = value;
        }
        private void ResetFields()
        {
            ListViewExercises.Items.Clear();
            ListViewMeds.Items.Clear();
            ListViewTreatments.Items.Clear();
            comboBoxPrescription.SelectedItem = null;
        }

        //para esconder ou mostrar o form
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
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(PrescriptionTitle);
            HideShowForm(show);
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
            //para que seja possível escolher o medicamento a ser editado em real-time
            try
            {
                MedName = ListViewMeds.SelectedItems[0].Text;
                MedDosage = ListViewMeds.SelectedItems[0].SubItems[1].Text;
                MedFrequency = ListViewMeds.SelectedItems[0].SubItems[2].Text;
            }
            catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MedName) || string.IsNullOrEmpty(MedDosage) || string.IsNullOrEmpty(MedFrequency)) return;
            if (!_validator.IsDouble(MedDosage))
            {
                MessageBox.Show("Introduza uma dosagem válida!!");
            }
            else
            {
                ListViewMeds.SelectedItems[0].Text = MedName;
                ListViewMeds.SelectedItems[0].SubItems[1].Text = MedDosage;
                ListViewMeds.SelectedItems[0].SubItems[2].Text = MedFrequency;
            }

        }

        private void ListViewExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //para que seja possível escolher o exercício a ser editado em real-time
            try
            {
                ExerciseName = ListViewExercises.SelectedItems[0].Text;
                ExerciseHour = ListViewExercises.SelectedItems[0].SubItems[1].Text;
                
            }
            catch
            {
            }
        }

        private void ListViewTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //para que seja possível escolher o tratamento a ser editado em real-time
            try
            {
                TreatmentName = ListViewTreatments.SelectedItems[0].Text;
                TreatmentDescription = ListViewTreatments.SelectedItems[0].SubItems[2].Text;

            }
            catch
            {
            }
        }

        private void BtnEditExercise_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExerciseName) || string.IsNullOrEmpty(ExerciseHour) ) return;
            if (!_validator.isValidDate(ExerciseHour))
            {
                MessageBox.Show("Introduza uma hora válida!!");
            }
            else
            {
                ListViewExercises.SelectedItems[0].Text = ExerciseName;
                ListViewExercises.SelectedItems[0].SubItems[1].Text = ExerciseHour;
            }


        }

        private void BtnEditTreatment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TreatmentName) || string.IsNullOrEmpty(TreatmentDescription)) return;

            ListViewTreatments.SelectedItems[0].Text = TreatmentName;
            ListViewTreatments.SelectedItems[0].SubItems[2].Text = TreatmentDescription;


        }

        private void BtnEditPrescription_Click(object sender, EventArgs e)
        {
            //
            // não nos ocorreu uma maneira mais fácil de implementar
            // por isso para editar uma prescrição
            // decidiu-se remover todos os itens de uma prescrição
            // e depois adicionar todos os que estão presentes nas listviews
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(PrescriptionTitle);
            var items = _unit.Items.GetItensByPrescription(prescription.ID);
            foreach (var item in items)
            {
                _unit.Items.Remove(item);
            }
            _unit.Prescriptions.Update(prescription);
            _unit.Complete();

            
            for (int i = 0; i < ListViewMeds.Items.Count; i++)
            {
                var med = (Medicamento)_factory.Create(ItemFactory.Meds);
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
                var exercise = (Exercise)_factory.Create(ItemFactory.Exercise);
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
                var treatment = (Treatment)_factory.Create(ItemFactory.Treatment);
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
