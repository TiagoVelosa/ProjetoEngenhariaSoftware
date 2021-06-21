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
using ProjetoEngenhariaSoftware;
using ProjetoEngenhariaSoftware.Prescription;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormDashBoardDoctor : Form
    {

        private CreatePrescription _createprescription;
        private EditPrescription _editPrescription;
        private readonly Credentials _user;
        public FormDashBoardDoctor(Credentials user)
        {
            InitializeComponent();
            _user = user;
            this.Type.Text = user.Person.Type;
            this.UserNameDoctor.Text = user.Username;

        }

        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {
            _createprescription = new CreatePrescription(_user);
            OperationsPanel.Controls.Add(_createprescription);
            _createprescription.BringToFront();
        }

        private void btnEditPrescription_Click(object sender, EventArgs e)
        {
            _editPrescription = new EditPrescription(_user);
            OperationsPanel.Controls.Add(_editPrescription);
            _editPrescription.BringToFront();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var LoginPage = new FormInicial();
            LoginPage.Show();
        }
    }
}
