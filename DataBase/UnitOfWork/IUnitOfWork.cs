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
        //IItemRepository Items { get; }

        IMedsInterface Meds { get; }

        IExerciseRepository Exercises { get; }

        ITreatmentsRepository Treatments { get; }


        int Complete();
    }
}