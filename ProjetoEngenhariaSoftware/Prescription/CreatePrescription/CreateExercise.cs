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
    public partial class CreateExercise : Form
    {

        private DataBase.Modules.Prescription _prescription;
        public CreateExercise(DataBase.Modules.Prescription prescription)
        {
            InitializeComponent();
            _prescription = prescription;
        }

        public string Name
        {
            get { return NameTxtBox.Text; }
            set { NameTxtBox.Text = value; }
        }

        public string Date
        {
            get { return DateTxtBox.Text; }
            set { DateTxtBox.Text = value; }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var validator = new ValidateItem();
            var strbuilder = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Date))
            {
                MessageBox.Show("Campos Incompletos!!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (!validator.isValidName(_prescription, Name))
                {
                    isValid = false;
                    strbuilder.Append("Já existe um item com esse nome!!");
                }
                else if (!validator.isValidDate(Date))
                {
                    isValid = false;
                    strbuilder.Append("Hora Inválida!!");
                }

                if (isValid)
                {
                    this.DialogResult = DialogResult.OK;
                    return;
                }
                else
                {
                    MessageBox.Show(strbuilder.ToString());
                    this.DialogResult = DialogResult.None;
                }
            }

        }
    }
}
