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
        private readonly IUnitOfWork _unit = new UnitOfWork();
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

        private void BtnLoadPrescription_Click(object sender, EventArgs e)
        {
            if (comboBoxPrescriptions.SelectedItem == null) return;
            var prescription = _unit.Prescriptions.GetPrescriptionByTitle(comboBoxPrescriptions.SelectedItem.ToString());
            var privateMeds = _unit.Meds.GetPrivateMeds(prescription.ID);
            var privateExercises = _unit.Exercises.GetPrivateExercises(prescription.ID);
            var privateTreatments = _unit.Treatments.GetPrivateTreatments(prescription.ID);

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
    }
}
