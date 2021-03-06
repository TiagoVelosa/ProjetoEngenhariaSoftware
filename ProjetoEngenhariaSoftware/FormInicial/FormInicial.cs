using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            Panel.Controls.Add(Login.Instance);
            Panel.Controls.Add(RegisterUser.Instance);
            


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login.Instance.BringToFront();
            RegisterUser.Instance.ResetFields();
            RegisterUser.Instance.ResetLabels();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser.Instance.BringToFront();
            Login.Instance.ResetLabels();
            Login.Instance.ResetFields();
        }
    }
}
