namespace School.Models;

public class Building : StorableEntity, ILocation
{
	public string Name { get; set; }

	public ICollection<IClassroom> Rooms { get; } = new List<IClassroom>();

	public Building( string name )
	{
		this.Name = name;
	}
}