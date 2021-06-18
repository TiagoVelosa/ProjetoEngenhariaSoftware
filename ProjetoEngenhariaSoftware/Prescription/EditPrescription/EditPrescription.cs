using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ProjetoEngenhariaSoftware.Prescription
{
    public partial class EditPrescription : UserControl
    {

        private readonly IUnitOfWork _unit = new UnitOfWork();
        private readonly Credentials _user;
        public EditPrescription(Credentials user)
        {
            InitializeComponent();
            _user = user;

        }

        private void LoadPrescriptions()
        {

        }
    }
}
