using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }


        public int AddEmployee(EmployeeEF employee)
        {
            db.Employees.Add(employee);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var result = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Employees.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }


        public EmployeeEF GetEmployeeById(int id)
        {
            var result = db.Employees.Where(x => x.Id == id).SingleOrDefault();
            return result;

        }

        public IEnumerable<EmployeeEF> GetEmployees()
        {
            var result = from b in db.Employees
                         select b;
            return result;
        }



        public int UpdateEmployee(EmployeeEF employee)
        {
            int res = 0;
            // find the record from Dbset that we need to modify
            //var result = (from b in db.Books
            //             where b.Id == book.Id
            //             select b).FirstOrDefault();

            var result = db.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = employee.Name;
                result.Dept = employee.Dept;
                result.Salary = employee.Salary;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
