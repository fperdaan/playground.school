using System.ComponentModel.DataAnnotations;

namespace School.Models;

public class Teacher : Person
{
	[Required]
	public Topic Topics { get; set; }
}