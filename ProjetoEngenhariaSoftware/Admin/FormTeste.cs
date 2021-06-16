using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new FormCreateDoctor();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!dialog.CheckFields())
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show("Campos incompletos!!");
                }
                else
                {

                    var credentials = new Credentials();
                    credentials.Username = dialog.Username;
                    credentials.Password = dialog.Password;

                    var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.PersonFactory);
                    var doctor = (Doctor) factory.Create(PersonFactory.Doctor);
                    doctor.name = dialog.Nome;
                    doctor.salary = Double.Parse(dialog.Salary);
                    doctor.telefone = dialog.PhoneNumber;
                    doctor.Type = "Doctor";
                    doctor.address = dialog.Address;
                    doctor.datebirth = DateTime.Parse(dialog.BirthDate);
                    credentials.Person = doctor;

                    _unit.Credentials.Add(credentials);
                    _unit.Doctors.Add(doctor);
                    _unit.Complete();

                    var node = new TreeNode(credentials.Username);
                    node.SelectedImageIndex = 0;

                    mainTreeView.Nodes.Add(node);
                }

            }
        }
    }
}
