using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

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


        public void Update(Person person, string Username)
        {
            var credential = Context.Credentials.FirstOrDefault(e => e.Username == Username);
            credential.Person = person;
        }
    }
}