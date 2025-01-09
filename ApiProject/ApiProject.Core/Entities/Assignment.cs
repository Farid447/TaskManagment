namespace ApiProject.Core.Entities;

    public class Assignment : BaseEntity
    {
	public string Title { get; set; }
	public string? Descryption { get; set; }
	public DateTime? DeadLine { get; set; } = DateTime.Now.AddDays(1);
	public int TopicId { get; set; }
	public Topic Topic { get; set; }
	public int? EmployeeId { get; set; }
	public Employee? Employee { get; set; }
	public ICollection<Tag>? Tags { get; set; }
}
