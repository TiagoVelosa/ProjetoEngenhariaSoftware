using System.Collections;
using System.Collections.Generic;

namespace ProjetoEngSoftClassLibrary.Models
{
    public class Client : Person
    {
        public IList<Prescription> Prescriptions { get; set; }
    }
}