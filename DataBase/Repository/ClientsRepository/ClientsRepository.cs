using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class ClientsRepository : Repository<Client> , IClientsRepository
    {

        public ClientsRepository(PrescriptionContext context) : base(context)
        {
            
        }
        public Client GetClientByPrescription(Prescription prescription)
        {
            return PrescriptionContext.Clients.Where(e => e.PrescriptionsList.Contains(prescription)).FirstOrDefault();
        }
        public Client GetClientByName(string name)
        {
            return PrescriptionContext.Clients.FirstOrDefault(e => e.name == name);
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }

    }
}