using System;
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
            
            InitializeComponent();
        }

        public void buttonAdicionar_Click(object sender, EventArgs e)
        {
            var context = new BDContext();
            if (!NameInput.Text.Trim().Equals("") && !PasswordInput.Text.Trim().Equals(""))
            {
                context.Add(new Utente { Username = NameInput.Text.Trim(), Password = PasswordInput.Text.Trim() });
                context.SaveChanges();

            }
        }
    }
}
