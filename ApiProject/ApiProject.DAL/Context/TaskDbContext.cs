using ApiProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.DAL.Context;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions opt) : base(opt)
    {
        
    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Tag> Tags { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
