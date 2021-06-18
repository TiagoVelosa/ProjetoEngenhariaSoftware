using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IMedsInterface : IRepository<Medicamento>
    {
        IEnumerable<Medicamento> GetMedsByPrescription(int ID);
    }
}