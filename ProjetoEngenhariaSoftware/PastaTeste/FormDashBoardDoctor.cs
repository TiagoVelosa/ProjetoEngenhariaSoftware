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
using ProjetoEngenhariaSoftware.PastaTeste;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormDashBoardDoctor : Form
    {
        
        private PrescriptionManager prescription = new PrescriptionManager();
        public FormDashBoardDoctor(Credentials user)
        {
            InitializeComponent();
            OperationsPanel.Controls.Add(prescription);
            this.Type.Text = user.Person.Type;
            this.UserNameDoctor.Text = user.Username;

        }

        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {

            prescription.BringToFront();
        }
    }
}
