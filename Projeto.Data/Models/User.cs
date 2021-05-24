using System.Collections.Generic;

namespace Projeto.Data.Models
{
    public class User : Person
    {
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();


    }
}