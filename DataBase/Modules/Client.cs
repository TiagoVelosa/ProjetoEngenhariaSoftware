using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace DataBase.Modules
{
    public class Client : Person

    {
        public IList<Prescription> PrescriptionsList { get; } = new List<Prescription>();
    }
}
