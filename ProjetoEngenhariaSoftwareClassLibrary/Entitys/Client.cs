using System.Collections;
using System.Collections.Generic;

namespace ProjetoEngenhariaSoftwareClassLibrary
{
    public class Client : Person
    {
        public ICollection<Prescription> Prescriptions { get; set; }
        
    }
}