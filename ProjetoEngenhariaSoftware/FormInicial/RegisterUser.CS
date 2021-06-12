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
using ClassLibraryEngSoft.Authentication.RegisterAuthentication;
using ClassLibraryEngSoft.Factory;
using ClassLibraryEngSoft.Repository;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using Microsoft.Identity.Client;

namespace ProjetoEngenhariaSoftware
{
    public sealed partial class RegisterUser : UserControl
    {
        private IFactory factory;
        private UnitOfWork _unit;

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
            factory = new PersonFactory();
            _unit = new UnitOfWork();
        }

        public void ResetFields()
        {
            UserTextBox.Text = "";
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

            if (UserTextBox.Text.Trim().Equals(""))
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
                if (PasswordTextBox.Text == ConfPasswordTextBox.Text)
                {
                    var availability = new UsernameAvailability();
                    if (availability.CheckUsernameAvailability(UserTextBox.Text))
                    {
                        var credentials = new Credentials();
                        credentials.Username = UserTextBox.Text;
                        credentials.Password = PasswordTextBox.Text;


                        var client = (DataBase.Modules.Client) factory.Create("Client");
                        client.address = AddressTextBox.Text;
                        client.datebirth = DateTime.Parse(BirthDatePicker.Text);
                        client.email = MailTextBox.Text;
                        client.name = NameTextBox.Text;
                        client.telefone = PhoneNumberTextBox.Text;
                        credentials.Person = client;

                        var request = new Request() {Data = client};
                        var NameAuth = new NameHandler();
                        var EmailAuth = new EmailHandler();
                        var PhoneAuth = new PhoneNumberHandler();

                        NameAuth.SetNext(EmailAuth);
                        EmailAuth.SetNext(PhoneAuth);

                        NameAuth.Authenticator(request);
                        if (request.ErrorMessage.Length != 0)
                        {
                            MessageBox.Show(
                                request.ErrorMessage.ToString(),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            _unit.Credentials.Add(credentials);
                            _unit.Clients.Add(client);
                            _unit.Complete();
                            MessageBox.Show(
                                "Registado com Sucesso!!",
                                "Sucesso",
                                MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username já existente!!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Password's não correspondem!!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
