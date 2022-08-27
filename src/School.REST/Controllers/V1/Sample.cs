using Microsoft.AspNetCore.Mvc;

using School.Models;
using School.DAL;
using School.BL.Fluent;
using Newtonsoft.Json;

namespace School.REST.Controllers;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]"), Route("api/latest/[controller]")]
public class Sample : ControllerBase
{
	private IFluentBuilding _building;

	public Sample( IFluentBuilding building )
	{
		this._building = building;
	}

    [HttpGet, Route("")]
    public Response<ILocation> Playground()
    {
		var result = this._building
						.SetName( "Building 1" )
						/*.AddRoom( "test" )
							.SetName("Changed")
						.Apply()*/
						.Construct();

		return new Response<ILocation>(result);
    }

}