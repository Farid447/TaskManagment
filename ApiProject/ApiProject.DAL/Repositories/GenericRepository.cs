using ApiProject.Core.Entities.Common;
using ApiProject.Core.Repositories;
using ApiProject.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.DAL.Repositories;

public class GenericRepository<T>(TaskDbContext _context) : IGenericRepository<T> where T : BaseEntity, new()
{
    protected DbSet<T> Table = _context.Set<T>();
    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await Table.Where(x=> x.Id == id).ExecuteDeleteAsync();
    }

    public IQueryable<T> GetAll()
        => Table.AsQueryable();

    public async Task<T?> GetByIdAsync(int id)
        => await Table.FindAsync(id);

    public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
}
