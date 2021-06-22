using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ClassLibraryEngSoft.Repository
{
    public class CredentialsRepository : Repository<Credentials>, ICredentialsRepository
    {
         
        public CredentialsRepository(PrescriptionContext context) : base(context)
        {
            
        }
        public IList<string> GetUsernames()
        {
            return PrescriptionContext.Credentials.Select(e => e.Username).ToList();
        }

        public Credentials GetPerson(string username)
        {
            return PrescriptionContext.Credentials.Where(e => e.Username == username).Include(e => e.Person).FirstOrDefault();
        }

        public IEnumerable<Credentials> GetDoctors()
        {
            return PrescriptionContext.Credentials.Include(e => e.Person).Where(e => e.Person.Type == "Doctor").ToList();
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }

    }
}