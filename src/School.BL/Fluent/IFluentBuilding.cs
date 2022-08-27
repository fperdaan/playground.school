using School.Models;

namespace School.BL.Fluent;

public interface IFluentBuilding
{
	public ILocation Location { get; }
	public ILocation Construct();
	public IFluentBuilding SetName( string name );

}