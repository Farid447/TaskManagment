using ApiProject.BL.DTOs.EmployeeDtos;
using ApiProject.Core.Entities;

namespace ApiProject.BL.Services.Interfaces;
public interface IEmployeeService
{

    Task<ICollection<Employee>> GetAllAsync();
    Task<int> CreateAsync(EmployeeCreateDto dto);
    Task UpdateAsync(int id, Employee employee);

    Task DeleteAsync(int id);
}
