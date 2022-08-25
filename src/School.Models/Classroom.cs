namespace School.Models;

public class Classroom : StorableEntity, IClassroom
{
	public int RoomSize { get; }
	public string Name { get; }
	public string Location { get; }	
	public Topic Topics { get; set; }

	public Classroom( string name, string location, int roomSize )
	{
		this.Name = name;
		this.RoomSize = roomSize;
		this.Location = location;
	}

	public Classroom( string name, string location, int roomSize, Topic topics ) : this( name, location, roomSize )
	{
		this.Topics = topics;
	}
}