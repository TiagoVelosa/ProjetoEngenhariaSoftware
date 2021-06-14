using System.Runtime.CompilerServices;
using ClassLibraryEngSoft.Repository;

namespace ClassLibraryEngSoft.UnitOfWork
{
    public interface IUnitOfWork
    {
        IClientsRepository Clients { get; }
        ICredentialsRepository Credentials { get; }
        IPrescriptionRepository Prescriptions { get; }

        IDoctorRepository Doctors { get; }
        IPersonRepository Persons { get; }


        int Complete();
    }
}