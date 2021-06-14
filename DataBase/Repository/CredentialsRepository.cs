using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ClassLibraryEngSoft.Repository
{
    public class CredentialsRepository : Repository<Credentials>, ICredentialsRepository
    {
         
        public CredentialsRepository(DBContext context) : base(context)
        {
            
        }
        public IList<string> GetUsernames()
        {
            return Context.Credentials.Select(e => e.Username).ToList();
        }

        public Credentials GetPerson(string username)
        {
            return Context.Credentials.Where(e => e.Username == username).Include(e => e.Person).Single();
        }

        public IEnumerable<Credentials> GetDoctors()
        {
            return Context.Credentials.Include(e => e.Person).Where(e => e.Person.Type == "Doctor").ToList();
        }


    }
}