using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.Authentication.RegisterAuthentication.Observer;
using ClassLibraryEngSoft.Factory;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormTeste : Form
    {
        private readonly IUnitOfWork _unit = new UnitOfWork();

        public void PopulateTreeView()
        {
            var doctors = _unit.Credentials.GetDoctors();
            foreach (var doctor in doctors)
            {
                mainTreeView.Nodes.Add(doctor.Username);
            }
        }

        public FormTeste()
        {
            
            InitializeComponent();
            PopulateTreeView();

        }

        void AddDoctor(Credentials credentials)
        {
            var node = new TreeNode(credentials.Username) {SelectedImageIndex = 0};
            mainTreeView.Nodes.Add(node);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new FormCreateDoctor();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {

                var node = new TreeNode(dialog.username) { SelectedImageIndex = 0 };
                mainTreeView.Nodes.Add(node);
                MessageBox.Show("Médico Registado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        
    }
}
