using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IPrescriptionRepository : IRepository<Prescription>
    {
        IEnumerable<Prescription> GetPrescriptionsByName(Client client);
        IEnumerable<Prescription> GetPrescriptionsByClientName(string name);
        //IEnumerable<Item> GetPrescriptionItems(Prescription prescription);

        Prescription GetPrescriptionByTitleWithDoctor(string title);
        Prescription GetPrescriptionByID(int id);

        IEnumerable<Prescription> GetPrescriptionsByDoctor(Doctor doctor);

        Prescription GetPrescriptionByTitle(string title);
    }
}