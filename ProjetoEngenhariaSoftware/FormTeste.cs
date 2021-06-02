using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ProjetoEngenhariaSoftware
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
           // combobox1 = new ComboBox();
            /*combobox1.Location = new System.Drawing.Point(20, 20);
            combobox1.Name = "ComboBox1";
            combobox1.Size = new System.Drawing.Size(200, 200);*/
            //Controls.Add(combobox1);
            
           /* foreach (var item in testeArray) //ListBox substituir por variável com os valores todos das prescrições
            {
                combobox1.Items.Add(item);
            }
           */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Insira um valor a ser inserido");
            }
        }
    }
}
