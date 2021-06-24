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

        private readonly DataBase.Modules.Prescription _prescription;
        private ValidateItem _validator = new ValidateItem();
        public CreateExercise(DataBase.Modules.Prescription prescription)
        {
            InitializeComponent();
            _prescription = prescription;
        }

        public string Name
        {
            get => NameTxtBox.Text;
            set => NameTxtBox.Text = value;
        }

        public string Date
        {
            get => DateTxtBox.Text;
            set => DateTxtBox.Text = value;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var strbuilder = new StringBuilder(); // onde vai ser construída a mensagem de erro
            bool isValid = true;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Date))
            {
                MessageBox.Show("Campos Incompletos!!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (!_validator.isValidName(_prescription, Name))
                {
                    isValid = false;
                    strbuilder.Append("Já existe um item com esse nome!!");
                }
                else if (!_validator.isValidDate(Date))
                {
                    isValid = false;
                    strbuilder.Append("Hora Inválida!!");
                }

                //caso o item seja válido
                if (isValid)
                {
                    this.DialogResult = DialogResult.OK;
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
