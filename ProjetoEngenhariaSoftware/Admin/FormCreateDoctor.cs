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

namespace ProjetoEngenhariaSoftware
{
    public partial class FormCreateDoctor : Form
    {
        private readonly IUnitOfWork _unit = new UnitOfWork();
        public string username;
        public FormCreateDoctor()
        {
            InitializeComponent();
        }

        public string Username
        {
            get => UsernameTextBox.Text;
            set => UsernameTextBox.Text = value;

        }

        public string Password
        {
            get => PasswordTextBox.Text;
            set => PasswordTextBox.Text = value;

        }

        public string Nome
        {
            get => NameTextBox.Text;
            set => NameTextBox.Text = value;

        }
        public string Salary
        {
            get => SalaryTextBox.Text;
            set => SalaryTextBox.Text = value;

        }

        public string Address
        {
            get => AddressTextBox.Text;
            set => AddressTextBox.Text = value;
        }

        public string PhoneNumber
        {
            get => PhoneNumberTextBox.Text;
            set => PhoneNumberTextBox.Text = value;
        }

        public string BirthDate
        {
            get => BirthDatePicker.Text;
            set => BirthDatePicker.Text = value;
        }

        public bool CheckFields() 
        {
            var requiredParameters = true;

            if (Username.Trim().Equals(""))
            {
                requiredParameters = false;
            }
            

            if (Password.Trim().Equals(""))
            {
                requiredParameters = false;
            }
            
            if (Name.Trim().Equals(""))
            {
                requiredParameters = false;
                
            }
            
            if (Address.Trim().Equals(""))
            {
                requiredParameters = false;
                
            }
            if (PhoneNumber.Trim().Equals(""))
            {
                requiredParameters = false;
               
            }
            
            if (BirthDate.Trim().Equals(""))
            {
                requiredParameters = false;
                
            }
            return requiredParameters;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Campos Incompletos!!", "Error");
            }
            else
            {
                var credentials = new Credentials { Username = Username, Password = Password };

                var factory = FactoryInstanciator.Instance.CreateFactory(FactoryInstanciator.PersonFactory);
                var doctor = (Doctor)factory.Create(PersonFactory.Doctor);
                doctor.name = Nome;
                doctor.salary = Double.Parse(Salary);
                doctor.telefone = PhoneNumber;
                doctor.Type = "Doctor";
                doctor.address = Address;
                doctor.datebirth = DateTime.Parse(BirthDate);
                credentials.Person = doctor;

                var Authenticator = new RegisterAuthentication(doctor);
                if (Authenticator.AuthenticateDoctor() == "Sucesso!")
                {
                    _unit.Credentials.Add(credentials);
                    _unit.Doctors.Add(doctor);
                    _unit.Complete();
                    username = credentials.Username;
                }
                else
                {
                    MessageBox.Show(Authenticator.AuthenticateDoctor());
                    this.DialogResult = DialogResult.None;
                }

            }
        }
    }
}
