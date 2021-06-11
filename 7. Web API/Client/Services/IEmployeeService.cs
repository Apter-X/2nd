using System.Threading.Tasks;
using System.Interactive.Async;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetEmployees();
}
