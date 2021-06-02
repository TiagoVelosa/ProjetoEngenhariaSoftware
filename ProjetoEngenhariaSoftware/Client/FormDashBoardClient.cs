using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEngenhariaSoftware.Client;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormDashBoardClient : Form
    {
        private UserPanel userpanel = new UserPanel();
        public FormDashBoardClient()
        {
            InitializeComponent();
            OperationsPanel.Controls.Add(userpanel);
        }

        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {
            userpanel.BringToFront();
        }
    }
}
