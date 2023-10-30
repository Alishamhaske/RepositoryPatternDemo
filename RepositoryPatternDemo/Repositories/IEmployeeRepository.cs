using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public interface IEmployeeRepository
    {

        IEnumerable<EmployeeEF> GetEmployees();

        EmployeeEF GetEmployeeById(int id);


        int AddEmployee(EmployeeEF employee);

        int DeleteEmployee(int id);
        int UpdateEmployee(EmployeeEF employee);
    }
}
