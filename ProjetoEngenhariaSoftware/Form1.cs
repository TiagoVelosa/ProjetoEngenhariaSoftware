﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Data;
using Projeto.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace ProjetoEngenhariaSoftware
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            var context = new ProjetoEngenhariaDeSoftware.Data.BDContext();
            InitializeComponent();
        }

        public void buttonConfirmar_Click(object sender, EventArgs e)
        {
            var context = new BDContext();
            if (!NameInput.Text.Equals("") && !PasswordInput.Text.Equals(""))
            {
                    
            }
        }
    }
}
