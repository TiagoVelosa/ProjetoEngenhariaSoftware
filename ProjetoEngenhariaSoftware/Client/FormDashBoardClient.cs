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
        private UserPanel _userpanel;
        public FormDashBoardClient(Credentials user)
        {
            InitializeComponent();
            _userpanel = new UserPanel((DataBase.Modules.Client) user.Person);
            OperationsPanel.Controls.Add(_userpanel);
            this.Type.Text = user.Person.Type;
            this.UserNameClient.Text = user.Username;
        }

        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {
            _userpanel.BringToFront();
        }
    }
}
