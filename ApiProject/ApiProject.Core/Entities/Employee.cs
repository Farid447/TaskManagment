namespace ApiProject.Core.Entities;

public class Employee : BaseEntity
{
    public string Ad { get; set; }
    public ICollection<Assignment> Assignments { get; set; }
}
