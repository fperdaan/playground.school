namespace School.Models;

public class Student : Person
{	
	public DateTime EnrollmentDate { get; set; } = DateTime.Now;
}