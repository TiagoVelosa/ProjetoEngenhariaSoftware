using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IClientsRepository : IRepository<Client>
    {
        Client GetClientByName(string name);


    }
}