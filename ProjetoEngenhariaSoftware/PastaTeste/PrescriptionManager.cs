using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEngenhariaSoftware.PastaTeste
{
    public partial class PrescriptionManager : UserControl
    {
        private AddPrescription add = new AddPrescription();
        private EditPrescription edit = new EditPrescription();
        public PrescriptionManager()
        {
            InitializeComponent();
            PanelPrescriptions.Controls.Add(add);
            PanelPrescriptions.Controls.Add(edit);
        }

        private void BtnAddPrescription_Click(object sender, EventArgs e)
        {
            add.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit.BringToFront();
        }
    }
}
