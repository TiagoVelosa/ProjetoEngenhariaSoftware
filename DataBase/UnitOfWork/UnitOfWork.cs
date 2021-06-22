using ClassLibraryEngSoft.Repository;
using ClassLibraryEngSoft.Repository.ItemsRepository;
using ClassLibraryEngSoft.Repository.TherapySessions;
using DataBase.Modules;

namespace ClassLibraryEngSoft.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PrescriptionContext _context;

        public IClientsRepository Clients { get; }
        public ICredentialsRepository Credentials { get; }
        public IPrescriptionRepository Prescriptions { get; }
        public IDoctorRepository Doctors { get; }
        public IPersonRepository Persons { get; }
        public IItemsRepository Items { get; }
        public IMedsInterface Meds { get; }
        public IExerciseRepository Exercises { get; }
        public ITreatmentsRepository Treatments { get; }
        public ITherapySessionRepository TherapySessions { get; }
        
        public UnitOfWork()
        {
            _context = new PrescriptionContext();
            Clients = new ClientsRepository(_context);
            Credentials = new CredentialsRepository(_context);
            Prescriptions = new PrescriptionRepository(_context);
            Doctors = new DoctorRepository(_context);
            Persons = new PersonRepository(_context);
            Items = new ItemsRepository(_context);
            Meds = new MedsRepository(_context);
            Exercises = new ExerciseRepository(_context);
            Treatments = new TreatmentsRepository(_context);
            TherapySessions = new TherapySessionRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}