namespace School.Models;

public class Class
{
	public IList<Student> Students { get; } = new List<Student>();
	public Teacher? Teacher { get; set; }
	public ICourse? Course { get; set; }
	public IClassroom? Room { get; set; } 
	public DateTime Date { get; }
}