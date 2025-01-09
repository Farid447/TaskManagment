using ApiProject.BL.DTOs.EmployeeDtos;
using ApiProject.BL.Exceptions.Common;
using ApiProject.BL.Services.Interfaces;
using ApiProject.Core.Entities;
using ApiProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.BL.Services.Implements;

public class AssignmentService(IAssignmentRepository _repo) : IAssignmentService
{
    public Task<int> CreateAsync(Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Assignment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, Assignment assignment)
    {
        throw new NotImplementedException();
    }
}
