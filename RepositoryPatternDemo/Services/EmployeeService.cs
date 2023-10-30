using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repositories;

namespace RepositoryPatternDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(EmployeeEF employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {

            return repo.DeleteEmployee(id);
        }

        public EmployeeEF GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public IEnumerable<EmployeeEF> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(EmployeeEF employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}
