using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class ClientsRepository : Repository<Client> , IClientsRepository
    {

        public ClientsRepository(DBContext context) : base(context)
        {
            
        }
        public IList<string> GetNames()
        {
            return Context.Clients.Select(e => e.name).ToList();
        }

        public IList<string> GetEmails()
        {
            return Context.Clients.Select(e => e.email).ToList();
        }

        public IList<string> GetPhoneNumbers()
        {
            return Context.Clients.Select(e => e.telefone).ToList();
        }

    }
}