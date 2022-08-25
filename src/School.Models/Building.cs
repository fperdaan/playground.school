namespace School.Models;

public class Building : StorableEntity, ILocation
{
	public string Name { get; set; }

	public ICollection<IClassroom> Rooms { get; } = new List<IClassroom>();
}