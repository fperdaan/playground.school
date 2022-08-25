using System.ComponentModel.DataAnnotations;

namespace School.Models;
abstract public class Person : StorableEntity
{
	[Required]
	public string FirstName { get; set; } = "";
	[Required]
	public string LastName { get; set; } = "";

	public string Name {
		get => this.FirstName + " " + this.LastName;
	}
}