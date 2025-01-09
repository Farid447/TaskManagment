using ApiProject.Core.Entities;
using ApiProject.Core.Repositories;
using ApiProject.DAL.Context;

namespace ApiProject.DAL.Repositories;

public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
{
    public AssignmentRepository(TaskDbContext context) : base(context)
    {
    }
}
