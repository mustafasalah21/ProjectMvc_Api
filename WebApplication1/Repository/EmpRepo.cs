using WebApplication1.Models;
using WebApplication1.Repository.Base;


namespace WebApplication1.Repository
{
    public class EmpRepo : MainRepository<Employee>, IEmpRepo
    {
        public EmpRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public decimal getSalary(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void setPayRoll(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
