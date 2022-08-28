namespace School.Models;

public class Student : Person
{	
	public DateOnly EnrollmentDate { get; set; } = DateOnly.FromDateTime( DateTime.Now );
}