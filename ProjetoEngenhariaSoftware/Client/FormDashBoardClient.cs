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
using ProjetoEngenhariaSoftware.Client;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormDashBoardClient : Form
    {
        private CheckPrescriptions _userpanel;
        private GivePermission _permissionpanel;
        private readonly Credentials _user;
        public FormDashBoardClient(Credentials user)
        {
            InitializeComponent();
            _user = user;
            this.Type.Text = user.Person.Type;
            this.UserNameClient.Text = user.Username;
        }

        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {
            _userpanel = new CheckPrescriptions(_user);
            OperationsPanel.Controls.Add(_userpanel);
            _userpanel.BringToFront();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var LoginPage = new FormInicial();
            LoginPage.Show();

        }

        private void BtnVisability_Click(object sender, EventArgs e)
        {
            _permissionpanel = new GivePermission(_user);
            OperationsPanel.Controls.Add(_permissionpanel);
            _permissionpanel.BringToFront();
        }
    }
}
