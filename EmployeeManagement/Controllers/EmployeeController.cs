using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
 
public class EmployeeController : Controller
{
    private readonly IEmployeeService _service;
 
    public EmployeeController(IEmployeeService service)
    {
        _service = service;
    }
 
    public async Task<IActionResult> Index()
    {
        return View(await _service.GetEmployeesAsync());
    }

    public async Task<IActionResult> Details(int id)
    {
        var employee = await _service.GetEmployeeAsync(id);
    
        if (employee == null)
            return NotFound();
    
        return View(employee);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var employee = await _service.GetEmployeeAsync(id);
    
        if (employee == null)
            return NotFound();
    
        return View(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Employee employee)
    {
        if (!ModelState.IsValid)
            return View(employee);
    
        await _service.UpdateEmployeeAsync(employee);
    
        return RedirectToAction(nameof(Index));
    }
 
    public IActionResult Create()
    {
        return View();
    }
 
    [HttpPost]
    public async Task<IActionResult> Create(Employee employee)
    {
        if (!ModelState.IsValid)
            return View(employee);
 
        await _service.CreateEmployeeAsync(employee);
 
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var employee = await _service.GetEmployeeAsync(id);
    
        if (employee == null)
            return NotFound();
    
        return View(employee);
    }
    
    [HttpPost]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteEmployeeAsync(id);
    
        return RedirectToAction(nameof(Index));
    }
}