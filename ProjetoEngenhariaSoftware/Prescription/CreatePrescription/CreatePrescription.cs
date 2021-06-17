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
        public DataBase.Modules.Prescription _prescription;
        private IUnitOfWork _unit = new UnitOfWork();
        public CreatePrescription()
        {
            InitializeComponent();
            _prescription = new DataBase.Modules.Prescription();
            _unit.Prescriptions.Add(_prescription);

        }

        private void BtnMeds_Click(object sender, EventArgs e)
        {
            var dialog = new CreateMed(_prescription);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
                var med = (Medicamento) factory.Create(ItemFactory.Meds);
                med.dosage = Double.Parse(dialog.Dosage);
                med.frequency = dialog.Frequency;
                med.Name = dialog.Name;
                med.Prescription = _prescription;

                _unit.Items.Add(med); 
                _unit.Complete();

                var item = new ListViewItem(dialog.Name);
                item.SubItems.Add(dialog.Dosage);
                item.SubItems.Add(dialog.Frequency);
                ListViewMeds.Items.Add(item);
                

            }
        }

        private void BtnExercises_Click(object sender, EventArgs e)
        {
            var dialog = new CreateExercise(_prescription);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
               var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
               var exercise = (Exercise)factory.Create(ItemFactory.Exercise);
               exercise.Name = dialog.Name;
               exercise.TimeSugestion = TimeSpan.Parse(dialog.Date);
               exercise.Prescription = _prescription;

               _unit.Items.Add(exercise); 
               _unit.Complete();

               var item = new ListViewItem(dialog.Name);
               item.SubItems.Add(dialog.Date);
               ListViewMeds.Items.Add(item);
            }
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            var dialog = new CreateTreatment(_prescription);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.ItemFactory);
                var treatment = (Treatment) factory.Create(ItemFactory.Treatment);
                treatment.Name = dialog.Name;
                treatment.Description = dialog.Description;
                treatment.Prescription = _prescription;

                _unit.Items.Add(treatment);
                _unit.Complete();

                var item = new ListViewItem(dialog.Name);
                item.SubItems.Add(dialog.Description);
                ListViewMeds.Items.Add(item);
            }
        }
    }
}
