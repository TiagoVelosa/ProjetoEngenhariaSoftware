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
        private readonly IUnitOfWork _unit = new UnitOfWork();
        private readonly Credentials _user;
        private readonly bool show = true;
        private readonly bool hide = false;
        public CheckPrescriptionsDoctor(Credentials user)
        {
            InitializeComponent();
            HideShowForm(hide);
            _user = user;
            Load();
        }
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
                comboBox1.Items.Add(prescription.title);
            }
        }
        private void HideShowForm(bool show_hide)
        {
            this.ListMeds.Visible = show_hide;
            this.ListExercises.Visible = show_hide;
            this.ListTreatments.Visible = show_hide;
            this.label3.Visible = show_hide;
            this.label4.Visible = show_hide;
            this.label2.Visible = show_hide;
            this.LabelClientName.Visible = show_hide;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            HideShowForm(show);
            ClearLists();
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(comboBox1.SelectedItem.ToString());  
            var exercises = _unit.Exercises.GetExercisesPublicByPrescription(prescription.ID);
            var meds = _unit.Meds.GetMedsPublicByPrescription(prescription.ID);
            var treatments = _unit.Treatments.GetTreatmentsPublicsByPrescription(prescription.ID);
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
