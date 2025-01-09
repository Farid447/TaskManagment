using ApiProject.Core.Entities;
using ApiProject.Core.Repositories;
using ApiProject.DAL.Context;

namespace ApiProject.DAL.Repositories;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(TaskDbContext _context) : base(_context)
    {
    }
}
