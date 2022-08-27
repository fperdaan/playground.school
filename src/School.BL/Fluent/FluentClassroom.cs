using School.Models;

namespace School.BL.Fluent;

public class FluentClassroom : IFluentClassroom
{
	private string _roomName = "";
	private int _roomSize;

	private IFluentBuilding _context;

	public FluentClassroom( IFluentBuilding context )
	{
		this._context = context;
	}

	public IFluentBuilding Apply()
	{
		return this._context;
	}


	public IFluentClassroom SetName( string name )
	{
		this._roomName = name;

		return this;
	}

	public IFluentClassroom SetSize( int size )
	{
		this._roomSize = size;

		return this;
	}
}