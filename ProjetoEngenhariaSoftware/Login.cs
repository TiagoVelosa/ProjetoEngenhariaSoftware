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

namespace ProjetoEngenhariaSoftware
{
    public partial class Login : UserControl
    {

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
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ParentForm.Hide();
            if (UsernameTextBox.Text.Trim().Equals(AdminUser) && PassWordTextBox.Text.Trim().Equals(AdminPassword))
            {
                var frm2 = new FormTeste();
                frm2.Show();
            }
        }
    }
}
