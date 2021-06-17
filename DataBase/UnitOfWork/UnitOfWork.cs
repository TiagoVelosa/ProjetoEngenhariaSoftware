using ClassLibraryEngSoft.Repository;
using DataBase.Modules;

namespace ClassLibraryEngSoft.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;

        public IClientsRepository Clients { get; }
        public ICredentialsRepository Credentials { get; }
        public IPrescriptionRepository Prescriptions { get; }
        public IDoctorRepository Doctors { get; }
        public IPersonRepository Persons { get; }

        public IItemRepository Items { get; }

        public UnitOfWork()
        {
            _context = new DBContext();
            Clients = new ClientsRepository(_context);
            Credentials = new CredentialsRepository(_context);
            Prescriptions = new PrescriptionRepository(_context);
            Doctors = new DoctorRepository(_context);
            Persons = new PersonRepository(_context);
            Items = new ItemRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}