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

namespace ProjetoEngenhariaSoftware
{
    public sealed partial class Login : UserControl
    {
        private readonly IUnitOfWork _unit;

        private const string AdminUser = "admin";
        private const string AdminPassword = "admin";

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
            _unit = new UnitOfWork();
        }

        public void ResetFields()
        {
            UsernameTextBox.Text = "";
            PassWordTextBox.Text = "";
            
        }

        public void ResetLabels()
        {
            UsernameError.Visible = false;
            PassWordError.Visible = false;
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

            if (PassWordTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                PassWordError.Visible = true;
            }
            else
            {
                requiredParameters = true;

            }

            return requiredParameters;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ResetLabels();
            if (CheckFields())
            {
                if (UsernameTextBox.Text.Trim().Equals(AdminUser) &&
                    PassWordTextBox.Text.Trim().Equals(AdminPassword))
                {
                    ParentForm.Hide();
                    var frm2 = new FormTeste();
                    frm2.Show();
                }
                else
                {
                    var user = _unit.Credentials.GetPerson(UsernameTextBox.Text.Trim());
                    if (user != null)
                    {
                        var authenticator = new LoginAuthenticator(user);
                        if (authenticator.CheckPassword(PassWordTextBox.Text))
                        {
                            ParentForm.Hide();
                            if (authenticator.CheckRole() == "Client")
                            {
                                var FormClient = new FormDashBoardClient(user);
                                FormClient.Show();
                            }
                            else
                            {
                                var FormDoctor = new FormDashBoardDoctor();
                                FormDoctor.user = user;
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
