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
        
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        private static RegisterUser _instance;


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


        // dá reset ás textboxes
        public void ResetFields()
        {
            UserTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfPasswordTextBox.Text = "";
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            BirthDatePicker.Text = "";
        }

        // dá reset às labels
        public void ResetLabels()
        {
            UsernameError.Visible = false;
            PassWordError.Visible = false;
            ConfirmPassWordError.Visible = false;
            NameError.Visible = false;
            AddressError.Visible = false;
            PhoneNumberError.Visible = false;
            BirthDateError.Visible = false;
        }

        // verfica se todos os campos foram preenchidos
        private bool CheckFields()
        {
            var requiredParameters = true;

            if (UserTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                UsernameError.Visible = true;
            }
            

            if (PasswordTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                PassWordError.Visible = true;
            }
            

            if (ConfPasswordTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                ConfirmPassWordError.Visible = true;
            }
           

            if (NameTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                NameError.Visible = true;
            }
            


            if (AddressTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                AddressError.Visible = true;
            }
            

            if (PhoneNumberTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                PhoneNumberError.Visible = true;
            }
            

            if (BirthDatePicker.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                BirthDatePicker.Visible = true;
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
                        // cria umas novas credenciais e uma nova instância de Client
                        var credentials = new Credentials {Username = UserTextBox.Text.Trim(), Password = PasswordTextBox.Text};
                        var factory = SimpleFactory.Instance.CreateFactory(FactoryType.PersonFactory);
                        var client = (DataBase.Modules.Client) factory.Create(PersonFactory.Client);
                        client.address = AddressTextBox.Text;
                        client.datebirth = DateTime.Parse(BirthDatePicker.Text);
                        client.name = NameTextBox.Text;
                        client.telefone = PhoneNumberTextBox.Text;
                        client.Type = "Client";
                        credentials.Person = client;

                        
                        var Authenticator = new AuthenticatorClient(client);
                        var ClientAuthentication = Authenticator.AuthenticateClient();
                        // verifica se todos os campos foram preenchidos corretamente
                        if (ClientAuthentication == "Sucesso!")
                        {
                            _unit.Credentials.Add(credentials);
                            _unit.Clients.Add(client);
                            _unit.Complete();
                            MessageBox.Show("Registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show(ClientAuthentication);
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
