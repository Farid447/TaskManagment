namespace ApiProject.Core.Entities;

public class Tag : BaseEntity
{
	public string Ad { get; set; }
	public ICollection<Assignment> Assignments { get; set; }
}
