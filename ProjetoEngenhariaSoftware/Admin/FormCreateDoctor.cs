using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormCreateDoctor : Form
    {
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

    }
}
