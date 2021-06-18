using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IPrescriptionRepository : IRepository<Prescription>
    {
        IEnumerable<Prescription> GetPrescriptionsByName(string name);
        //IEnumerable<Item> GetPrescriptionItems(Prescription prescription);

        Prescription GetPrescriptionByID(int id);

        IEnumerable<Prescription> GetPrescriptionsByDoctor(Doctor doctor);
    }
}