using DataBase.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware.Therapy
{
    public partial class AddNote : Form
    {
        public string nota { get { return textBoxNota.Text; } }
        public AddNote(List<Treatment> tratamentos_concluidos)
        {
            InitializeComponent();
            CarregarTratamentos(tratamentos_concluidos);
        }
        private void CarregarTratamentos(List<Treatment> tratamentos_concluidos)
        {
            foreach (var tratamento in tratamentos_concluidos)
            {
                listViewTratamentos.Items.Add(tratamento.Description);
            }
        }

        private void btnAdicionarNota_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        

        private void listViewTratamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}