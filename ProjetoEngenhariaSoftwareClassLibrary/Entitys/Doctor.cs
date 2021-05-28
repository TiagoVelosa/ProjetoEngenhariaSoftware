using System.Collections;
using System.Collections.Generic;

namespace ProjetoEngenhariaSoftwareClassLibrary
{
    public class Doctor : Person
    {
        public double salary { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }


    }
}