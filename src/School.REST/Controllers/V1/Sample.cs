using Microsoft.AspNetCore.Mvc;

using School.Models;
using School.BL.Fluent;
using School.DAL;

namespace School.REST.Controllers.V1;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]"), Route("api/latest/[controller]")]
public class Sample : ControllerBase
{
    [HttpGet, Route("")]
   	public virtual Response<ILocation> Playground( [FromServices] IFluentBuilding builder )
	{
		var result = builder
						.SetName( "Building 1" )
						/*.AddRoom( "test" )
							.SetName("Changed")
						.Apply()*/
						.Construct();

		return new Response<ILocation>(result);
    }

	[HttpGet, Route("test")]
	[ProducesDefaultResponseType( typeof( IEnumerable<Person> ) )]
   	public virtual IActionResult Test3( [FromServices] IRepository<Person> repo )
	{
		return Ok( repo.Query().Select( p => new { p.FirstName, p.LastName } ) );
    }

	[HttpGet, Route("async-test1")]
    public virtual async IAsyncEnumerable<int> Test1()
    {
		for (int counter = 0; counter < 10; counter++)
		{
			await Task.Delay(700);
			yield return counter;
		}
    }

	[HttpGet, Route("async-test2")]
    public virtual Response<IAsyncEnumerable<int>> Test2()
    {
		return new Response<IAsyncEnumerable<int>>(Test1());
    }

	
}


