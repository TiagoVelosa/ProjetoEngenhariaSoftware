using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft.Repository
{
    public class PersonRepository : Repository<Person> , IPersonRepository
    {
        public PersonRepository(PrescriptionContext context) : base(context)
        {

        }

        public IList<string> GetPhoneNumbers()
        {
            return PrescriptionContext.Persons.Select(e => e.telefone).ToList();
        }

        public IEnumerable<Person> GetClients()
        {
            return PrescriptionContext.Persons.Where(e => e.Type == "Client").ToList();
        }

        public Person GetPersonByName(string name)
        {
            return PrescriptionContext.Persons.FirstOrDefault(e => e.name == name);
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }
    }
}