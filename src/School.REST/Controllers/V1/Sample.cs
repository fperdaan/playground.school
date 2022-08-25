using Microsoft.AspNetCore.Mvc;

using School.Models;
using School.DAL;
using School.REST.Models;
using Microsoft.AspNetCore.Http.Extensions;

using System.Web;

namespace School.REST.Controllers;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]"), Route("api/latest/[controller]")]
public class Sample : ControllerBase
{
	private IRepository<Person> _repo;

	public Sample( IRepository<Person> repo )
	{
		this._repo = repo;
	}
	
    [HttpGet, Route("{id}")]
    public ActionResult<Person> Get( int id )
    {	
		Person? result = this._repo.GetById( id ).Result;

		if( result != null )
			return Ok( result );

		else 
			return NotFound();
    }

    [HttpGet, Route("")]
    public PagedList<Person> List( [FromQuery] PaginationFilter pagination )
    {

			// var builder = new QueryMutator( Request.GetDisplayUrl() );

			// builder.Add( "test", "value1" )
			// 	   .Replace( "pageNumber", "10" )
			// 	   .Remove( "foo" );


		//	Console.WriteLine( builder );
		//	Console.WriteLine( Request.GetDisplayUrl() );


		return PagedList<Person>.ToPagedList( 
			source: this._repo.FindAll().OrderBy( p => p.ID ),
			request: Request, 
			startAt: pagination.StartAt, 
			maxResults: pagination.MaxResults 
		);
    }

}