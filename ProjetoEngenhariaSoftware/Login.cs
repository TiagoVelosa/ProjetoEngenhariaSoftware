using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware
{
    public partial class Login : UserControl
    {

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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
