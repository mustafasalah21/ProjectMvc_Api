using WebApplication1.Models;
using WebApplication1.Repository.Base;


namespace WebApplication1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(AppDbContext context)
        { 
           _context = context;
           categories = new MainRepository<Category>(_context);
           items = new MainRepository<Item>(_context);
           emplyees = new EmpRepo(_context);
        }

        private readonly AppDbContext _context;

        public IRepository<Category> categories { get; private set; }

        public IRepository<Item> items { get; private set; }

        public IEmpRepo emplyees { get; private set; }

        public int CommitChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
