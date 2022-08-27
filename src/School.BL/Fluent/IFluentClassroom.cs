namespace School.BL.Fluent;

public interface IFluentClassroom
{
	public IFluentBuilding Apply();

	public IFluentClassroom SetName( string name );
	public IFluentClassroom SetSize( int size );
}