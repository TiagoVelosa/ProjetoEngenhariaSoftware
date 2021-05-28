using System.Collections;
using System.Collections.Generic;

namespace ProjetoEngSoftClassLibrary.Models
{
    public class Doctor : Person
    {
        public double salary { get; set; }

        public IList<Prescription> Prescriptions { get; set; }
    }
}