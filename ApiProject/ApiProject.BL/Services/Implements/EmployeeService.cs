using ApiProject.BL.DTOs.EmployeeDtos;
using ApiProject.BL.Services.Interfaces;
using ApiProject.Core.Entities;
using ApiProject.BL.Services.Interfaces;

namespace ApiProject.BL.Services.Implements;
public class EmployeeService : IEmployeeService
{
    public Task<int> CreateAsync(EmployeeCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Employee>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, Employee employee)
    {
        throw new NotImplementedException();
    }
}
