namespace School.Models;

abstract public class Person : StorableEntity
{
	public string FirstName { get; set; } = "";
	public string SirName { get; set; } = "";

	public string Name {
		get => this.FirstName + " " + this.SirName;
	}
}