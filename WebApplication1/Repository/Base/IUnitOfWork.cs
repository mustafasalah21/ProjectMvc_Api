using WebApplication1.Models;

namespace WebApplication1.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> categories { get;  }
        IRepository<Item> items { get; }
        IEmpRepo emplyees { get;  }
        int CommitChanges();
    }
}
