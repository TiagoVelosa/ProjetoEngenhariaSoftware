using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware
{
    public sealed partial class RegisterUser : UserControl
    {

        public static RegisterUser _instance;

        public static RegisterUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RegisterUser();
                }

                return _instance;
            }
        }
        public RegisterUser()
        {
            InitializeComponent();
        }

        public void ResetFields()
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfPasswordTextBox.Text = "";
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            BirthDatePicker.Text = "";
            MailTextBox.Text = "";
        }

        public void ResetLabels()
        {
            UsernameError.Visible = false;
            PassWordError.Visible = false;
            ConfirmPassWordError.Visible = false;
            NameError.Visible = false;
            AddressError.Visible = false;
            PhoneNumberError.Visible = false;
            BirthDateError.Visible = false;
            MailError.Visible = false;
        }

        private bool CheckFields()
        {
            var requiredParameters = true;

            if (UsernameTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                UsernameError.Visible = true;
            }
            else
            {
                requiredParameters = true;


            }

            if (PasswordTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                PassWordError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            if (ConfPasswordTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                ConfirmPassWordError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            if (NameTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                NameError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }


            if (AddressTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                AddressError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            if (PhoneNumberTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                PhoneNumberError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            if (BirthDatePicker.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                BirthDatePicker.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            if (MailTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                MailError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            return requiredParameters;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetLabels();
            ResetFields();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ResetLabels();
            if (CheckFields())
            {
                var person = new Client
                {
                    address = AddressTextBox.Text,
                    datebirth = DateTime.Parse(BirthDatePicker.Text),
                    email = MailTextBox.Text,
                    name = NameTextBox.Text,
                    password = PasswordTextBox.Text,
                    telefone = int.Parse(PhoneNumberTextBox.Text),
                    username = UserTextBox.Text
                };


            }
        }
    }
}
