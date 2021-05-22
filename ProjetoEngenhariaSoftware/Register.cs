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
    public partial class Register : UserControl
    {

        private static Register _instance;

        public static Register Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Register();
                }

                return _instance;
            }
        }
        public Register()
        {
            InitializeComponent();
        }
    }
}
