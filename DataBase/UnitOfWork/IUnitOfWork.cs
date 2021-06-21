﻿using System.Runtime.CompilerServices;
using ClassLibraryEngSoft.Repository;
using ClassLibraryEngSoft.Repository.ItemsRepository;

namespace ClassLibraryEngSoft.UnitOfWork
{
    public interface IUnitOfWork
    {
        IClientsRepository Clients { get; }
        ICredentialsRepository Credentials { get; }
        IPrescriptionRepository Prescriptions { get; }
        IDoctorRepository Doctors { get; }
        IPersonRepository Persons { get; }
        IItemsRepository Items { get; }

        IMedsInterface Meds { get; }

        IExerciseRepository Exercises { get; }

        ITreatmentsRepository Treatments { get; }


        int Complete();
    }
}