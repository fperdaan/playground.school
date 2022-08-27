using School.DAL;
using School.Models;

namespace School.BL.Fluent;

public partial class FluentBuilding : IFluentBuilding
{
	private IRepository<Student> _buildingRepo;
	public ILocation Location { get; }

	public FluentBuilding( IRepository<Student> repo )
	{
		this._buildingRepo = repo;

		this.Location = new Building("mock");
	}

	public IFluentClassroom AddRoom() => new FluentClassroom( this );

	public ILocation Construct()
	{
		return this.Location;
	} 

	public IFluentBuilding SetName( string name )
	{
		this.Location.Name = name;

		return this;
	}
}