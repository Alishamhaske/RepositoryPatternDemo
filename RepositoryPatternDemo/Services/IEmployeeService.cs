using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IEmployeeService
    {

        IEnumerable<EmployeeEF> GetEmployees();

        EmployeeEF GetEmployeeById(int id);


        int AddEmployee(EmployeeEF employee);




        int DeleteEmployee(int id);
        int UpdateEmployee(EmployeeEF employee);
    }
}
