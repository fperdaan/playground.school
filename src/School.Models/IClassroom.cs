namespace School.Models;

public interface IClassroom : IStorable
{
	public int RoomSize { get; }
	public string Name { get; }
	public string Location { get; }
	public Topic Topics { get; }
}