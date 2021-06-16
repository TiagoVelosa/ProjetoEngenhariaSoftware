﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.PastaTeste
{
    public partial class PrescriptionManager : UserControl
    {
        private CreatePrescription _addPrescription = new CreatePrescription();
        public Person user { get; set; }
        
        public PrescriptionManager()
        {
            InitializeComponent();
            PanelPrescriptions.Controls.Add(_addPrescription);
            
        }

        private void BtnAddPrescription_Click(object sender, EventArgs e)
        {
            _addPrescription.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
