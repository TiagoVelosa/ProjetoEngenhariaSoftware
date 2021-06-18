using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft.Repository
{
    public class PersonRepository : Repository<Person> , IPersonRepository
    {
        public PersonRepository(DBContext context) : base(context)
        {

        }

        public IList<string> GetPhoneNumbers()
        {
            return Context.Persons.Select(e => e.telefone).ToList();
        }

        public IEnumerable<Person> GetClients()
        {
            return Context.Persons.Where(e => e.Type == "Client").ToList();
        }

        public Person GetPersonByName(string name)
        {
            return Context.Persons.FirstOrDefault(e => e.name == name);
        }
    }
}