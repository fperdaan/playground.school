namespace School.Models;

public interface ILocation : IStorable
{
	public ICollection<IClassroom> Rooms { get; }

	public string Name { get; set; }
}