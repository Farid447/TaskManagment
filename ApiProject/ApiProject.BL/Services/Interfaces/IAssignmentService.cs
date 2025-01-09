using ApiProject.Core.Entities;

namespace ApiProject.BL.Services.Interfaces;
public interface IAssignmentService
{
    Task<ICollection<Assignment>> GetAllAsync();
    Task<int> CreateAsync(Assignment assignment);
    Task UpdateAsync(int id, Assignment assignment);

    Task DeleteAsync(int id);

}
