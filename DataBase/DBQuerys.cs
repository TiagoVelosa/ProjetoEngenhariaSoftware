using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft
{
    public class DBQuerys
    {
        private DBContext _DbContext;

        public DBQuerys()
        {
            _DbContext = new DBContext();
        }

        public List<string> GetUsernames()
        {
            return _DbContext.Persons.Select(e => e.username).ToList();
        }

        public List<string> GetPhoneNumbers()
        {
            return _DbContext.Persons.Select(e => e.telefone).ToList();
        }

        public List<Person> GetPersons()
        {
            return _DbContext.Persons.ToList();
        }
    }
}