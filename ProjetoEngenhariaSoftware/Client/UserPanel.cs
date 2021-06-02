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
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Client
{
    public partial class UserPanel : UserControl
    {
        public UserPanel()
        {
            InitializeComponent();
            this.comboBoxPrescription.Items.Clear();
            var dado = new DBQuerys();
            var dados = dado.GetPrescriptionsById(1);
            foreach (var item in dados)
            {
                comboBoxPrescription.Items.Add(item).ToString();

            }
        }

        private void BtnLoadPrescription_Click(object sender, EventArgs e)
        {
            var querys = new DBQuerys();

            var presciption = (Prescription)comboBoxPrescription.SelectedItem;
            var exercises = querys.GetExercises(presciption.ID);
            var treats = querys.GetTreatments(presciption.ID);
            var meds = querys.GetMeds(presciption.ID);
            foreach (var exercise in exercises)
            {
                var item = new ListViewItem(exercise.Name);
                item.SubItems.Add(exercise.TimeSugestion.ToString());
                ListExercises.Items.Add(item);

            }
            foreach (var exercise in meds)
            {
                var item = new ListViewItem(exercise.Name);
                item.SubItems.Add(exercise.dosage.ToString());
                item.SubItems.Add(exercise.frequency);
                ListMeds.Items.Add(item);


            }
            foreach (var exercise in treats)
            {
                var item = new ListViewItem(exercise.Name);
                item.SubItems.Add(exercise.Description);
                ListTreatments.Items.Add(item);

            }
        }
    }
}
