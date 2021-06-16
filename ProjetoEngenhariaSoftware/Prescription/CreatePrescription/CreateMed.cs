using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware.Prescription.CreatePrescription
{
    public partial class CreateMed : Form
    {
        public CreateMed()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return NameTxtBox.Text; }
            set { NameTxtBox.Text = value; }
        }

        public string Dosage
        {
            get { return DosageTxtBox.Text; }
            set { DosageTxtBox.Text = value; }
        }

        public string Frequency
        {
            get { return FrequencyTxtBox.Text; }
            set { FrequencyTxtBox.Text = value; }
        }
    }
}
