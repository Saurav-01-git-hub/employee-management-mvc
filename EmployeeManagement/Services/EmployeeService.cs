using EmployeeManagement.Models;
 
public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;
 
    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }
 
    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await _repository.GetAllAsync();
    }
 
    public async Task<Employee?> GetEmployeeAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
 
    public async Task CreateEmployeeAsync(Employee employee)
    {
        await _repository.AddAsync(employee);
    }
 
    public async Task UpdateEmployeeAsync(Employee employee)
    {
        await _repository.UpdateAsync(employee);
    }
 
    public async Task DeleteEmployeeAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}