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
        private readonly IUnitOfWork _unit = new UnitOfWork(new PrescriptionContext());
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

            if (Salary.Trim().Equals(""))
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
                var userFactory = SimpleFactory.Instance.CreateFactory(FactoryType.PersonFactory);
                var doctor = (Doctor)userFactory.Create(PersonFactory.Doctor);
                doctor.Name = Nome;
                doctor.Salary = Salary;
                doctor.Telefone = PhoneNumber;
                doctor.Type = "Doctor";
                doctor.Address = Address;
                doctor.Datebirth = DateTime.Parse(BirthDate);
                credentials.Person = doctor;

                var Authenticator = new AuthenticatorDoctor(doctor);
                var DoctorAuthentication = Authenticator.AuthenticateDoctor();
                if (DoctorAuthentication == "Sucesso!")
                {
                    _unit.Credentials.Add(credentials);
                    _unit.Doctors.Add(doctor);
                    _unit.Complete();
                    username = credentials.Username;
                    MessageBox.Show("Registado com sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(DoctorAuthentication);
                    this.DialogResult = DialogResult.None;
                }

            }
        }
    }
}
