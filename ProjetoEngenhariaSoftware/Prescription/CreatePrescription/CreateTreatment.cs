using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.Authentication.RegisterAuthentication.Prescriptions;

namespace ProjetoEngenhariaSoftware.Prescription.CreatePrescription
{
    public partial class CreateTreatment : Form
    {
        private DataBase.Modules.Prescription _prescription;
        public CreateTreatment(DataBase.Modules.Prescription prescription)
        {
            InitializeComponent();
            _prescription = prescription;
        }

        public string Name
        {
            get { return NameTxtBox.Text; }
            set { NameTxtBox.Text = value; }
        }

        public string Description
        {
            get { return DescriptionTxtBox.Text; }
            set { DescriptionTxtBox.Text = value; }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var validator = new ValidateItem();
            bool isValid = true;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Campos Incompletos!!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (validator.isValidName(_prescription, Name))
                {
                    isValid = false;
                }

                if (isValid)
                {
                    this.DialogResult = DialogResult.OK;
                    return;
                }
                else
                {
                    MessageBox.Show("Já existe um item com este nome!!");
                    this.DialogResult = DialogResult.None;
                }
            }
        }
    }
}
