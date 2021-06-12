using ClassLibraryEngSoft.Repository;
using DataBase.Modules;

namespace ClassLibraryEngSoft.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;

        public IClientsRepository Clients { get; }
        public ICredentialsRepository Credentials { get; }


        public UnitOfWork()
        {
            _context = new DBContext();
            Clients = new ClientsRepository(_context);
            Credentials = new CredentialsRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}