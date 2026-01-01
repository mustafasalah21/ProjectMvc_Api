using WebApplication1.Models;

namespace WebApplication1.Repository.Base
{
    public interface IEmpRepo : IRepository<Employee>
    {
        void setPayRoll(Employee employee);

        decimal getSalary(Employee employee);
    }
}
