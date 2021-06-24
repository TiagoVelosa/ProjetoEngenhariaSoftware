using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.Authentication.LoginAuthentication;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using ProjetoEngenhariaSoftware.Secretaria;

namespace ProjetoEngenhariaSoftware
{
    public sealed partial class Login : UserControl
    {
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
        //credenciais de admin e secretária
        private const string AdminUser = "admin";
        private const string AdminPassword = "admin";
        private const string SecretaryUser = "secretary";
        private const string SecretaryPassword = "secretary";

        private static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login();
                }

                return _instance;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private string Username
        {
            get => UsernameTextBox.Text;
            set => UsernameTextBox.Text = value;
        }

        private string Password
        {
            get => PassWordTextBox.Text;
            set => PassWordTextBox.Text = value;
        }

        public void ResetFields()
        {
            Username = "";
            Password = "";
            
        }

        public void ResetLabels()
        {
            UsernameError.Visible = false;
            PassWordError.Visible = false;
        }

        private bool CheckFields()
        {
            //verifica todos os campos
            var requiredParameters = true;

            if (Username.Trim().Equals(""))
            {
                requiredParameters = false;
                UsernameError.Visible = true;
            }
            

            if (Password.Trim().Equals(""))
            {
                requiredParameters = false;
                PassWordError.Visible = true;
            }
            

            return requiredParameters;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ResetLabels();
            if (CheckFields())
            {
                if (Username.Trim().Equals(AdminUser) && Password.Trim().Equals(AdminPassword))
                {
                    ParentForm.Hide();
                    var frm2 = new FormTeste();
                    frm2.Show();
                }
                else if (Username.Trim().Equals(SecretaryUser) && Password.Trim().Equals(SecretaryPassword))
                {
                    ParentForm.Hide();
                    var frm2 = new FormSecretaria();
                    frm2.Show();
                }
                else
                {
                    var user = _unit.Credentials.GetPerson(Username.Trim());
                    if (user != null)
                    {
                        //verifica o Role da pessoa
                        var authenticator = new LoginAuthenticator(user);
                        if (authenticator.CheckPassword(Password))
                        {
                            ParentForm.Hide();
                            if (authenticator.CheckRole() == "Client")
                            {
                                var FormClient = new FormDashBoardClient(user);
                                FormClient.Show();
                            }
                            else
                            {
                                var FormDoctor = new FormDashBoardDoctor(user);
                                FormDoctor.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Incorreta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário Inexistente");
                    }
                }
            }
        }
    }
}
