using EmployeeManagement.Models;
 
public interface IEmployeeService
{
    Task<List<Employee>> GetEmployeesAsync();
    Task<Employee?> GetEmployeeAsync(int id);
    Task CreateEmployeeAsync(Employee employee);
    Task UpdateEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(int id);
}