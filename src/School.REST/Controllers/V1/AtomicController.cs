using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.DAL;
using School.Models;

namespace School.REST.Controllers;

abstract public class AtomicController<T> : ControllerBase where T : StorableEntity
{
	protected IRepository<T> _repo;

	public AtomicController( IRepository<T> repo )
	{
		this._repo = repo;
	}

    [HttpGet, Route("{id}")]
    public virtual Response<T> Get( int id )
    {	
		T? result = this._repo.GetById( id ).Result;

		if( result != null )
			return new Response<T>( result );

		else 
			return new Response<T>( "Unable to find the object with the specified id" );
    }

    [HttpGet, Route("")]
    public virtual PagedResponse<T> List( [FromQuery] PaginationFilter pagination )
    {
		return PagedResponse<T>.ToPagedResponse(
			source: this._repo.FindAll().OrderBy( p => p.ID ),
			request: Request, 
			startAt: pagination.StartAt, 
			maxResults: pagination.MaxResults 
		);
    }
}