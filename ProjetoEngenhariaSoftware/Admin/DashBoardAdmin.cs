using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.Authentication.RegisterAuthentication;
using ClassLibraryEngSoft.Factory;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormTeste : Form
    {
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());


        public FormTeste()
        {
            
            InitializeComponent();
            PopulateTreeView();

        }

        // mostra os dotores presentes no sistema
        public void PopulateTreeView()
        {
            var doctors = _unit.Credentials.GetDoctors();
            foreach (var doctor in doctors)
            {
                mainTreeView.Nodes.Add(doctor.Username);
            }
        }

        private void BtnLoggout_Click(object sender, EventArgs e)
        {
            this.Close();
            var LoginPage = new FormInicial();
            LoginPage.Show();
        }

        private void BtnRegisterDoctor_Click(object sender, EventArgs e)
        {
            var dialog = new FormCreateDoctor();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {

                var node = new TreeNode(dialog.username) { SelectedImageIndex = 0 };
                mainTreeView.Nodes.Add(node);

            }
        }
    }
}
