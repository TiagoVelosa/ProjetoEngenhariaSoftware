using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Modules
{
    public class Doctor  : Person
    {
        public string Salary { get; set; }

        public IList<Prescription> PrescriptionsList { get; } = new List<Prescription>();
    }
}
