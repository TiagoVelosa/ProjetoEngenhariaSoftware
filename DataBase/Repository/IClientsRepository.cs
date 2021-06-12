using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IClientsRepository : IRepository<Client>
    {
        IList<string> GetNames();
        IList<string> GetEmails();
        IList<string> GetPhoneNumbers();


    }
}