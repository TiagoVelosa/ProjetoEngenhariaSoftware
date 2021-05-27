using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjetoEngenhariaSoftwareClassLibrary;
using ProjetoEngenhariaSoftwareClassLibrary.Authentication;

namespace ProjetoEngenhariaSoftware
{
    public sealed partial class Register : UserControl
    {

        private static Register _instance;

        public static Register Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Register();
                }

                return _instance;
            }
        }

        
        public Register()
        {
            InitializeComponent();
        }

        public void ResetFields()
        {
            UsernameTextBox.Text = "";
            PassWordTextBox.Text = "";
            NameTextBox.Text = "";
            CellPhoneTextBox.Text = "";
        }

        public void ResetLabels()
        {
            UsernameError.Visible = false;
            PassWordError.Visible = false;
            NameError.Visible = false;
            CellPhoneError.Visible = false;

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

            if (NameTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                NameError.Visible = true;
            }
            else
            {
                requiredParameters = true;
                
            }

            if (CellPhoneTextBox.Text.Trim().Equals(""))
            {
                requiredParameters = false;
                CellPhoneError.Visible = true;
            }
            else
            {
                requiredParameters = true;
               
            }

            return requiredParameters;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ResetLabels();
            if (CheckFields())
            {
                var register = new RegisterAuthentication();
                if (register.CheckUsernameAvailability(UsernameTextBox.Text))
                {
                    DatabaseQuerys.Instance.InsertClient(UsernameTextBox.Text, PassWordTextBox.Text, NameTextBox.Text,
                        CellPhoneTextBox.Text);
                    MessageBox.Show("Cliente criado com sucesso", "Registo efetuado", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Username já existente, por favor escolha outro");
                }
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
            ResetLabels();
        }
    }
}
