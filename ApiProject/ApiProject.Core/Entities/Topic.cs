namespace ApiProject.Core.Entities;

public class Topic : BaseEntity
{
	public string Ad { get; set; }
    public ICollection<Assignment> Assignments { get; set; }

}
