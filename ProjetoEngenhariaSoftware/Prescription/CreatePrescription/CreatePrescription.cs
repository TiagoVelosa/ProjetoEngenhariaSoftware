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
        private IUnitOfWork _unit = new UnitOfWork();
        public CreatePrescription()
        {
            InitializeComponent();
            _prescription = new DataBase.Modules.Prescription();

        }

        private void BtnMeds_Click(object sender, EventArgs e)
        {
            var dialog = new CreateMed();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.Name) || string.IsNullOrEmpty(dialog.Dosage) || string.IsNullOrEmpty(dialog.Frequency))
                    MessageBox.Show("Campos Incompletos!!, Medicamento não adicionado!!");
                else
                {
                    var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
                    var med = (Medicamento) factory.Create(ItemFactory.Meds);

                    _prescription.Items.ToList().Add(med);
                    var item = new ListViewItem(dialog.Name);
                    item.SubItems.Add(dialog.Dosage);
                    item.SubItems.Add(dialog.Frequency);
                    ListViewMeds.Items.Add(item);
                }

            }
        }

        private void BtnExercises_Click(object sender, EventArgs e)
        {

        }
    }
}
