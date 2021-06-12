using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface ICredentialsRepository : IRepository<Credentials>
    {
        IList<string> GetUsernames();
        void Update(Person person, string username);
    }
}