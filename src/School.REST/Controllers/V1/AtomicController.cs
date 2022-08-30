using Microsoft.AspNetCore.Mvc;
using System.Net;

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
    public virtual async Task<Response<T>> Get( int id )
    {	
		T? result = await this._repo.GetById( id );

		if( result != null )
			return new Response<T>( result );

		else 
			return new ErrorResponse<T>( "id", "Unable to find the object with the specified id", HttpStatusCode.NotFound );
    }

    [HttpGet, Route("")]
    public virtual PagedResponse<T> List( [FromQuery] PaginationFilter pagination )
    {
		return PagedResponse<T>.ToPagedResponse(
			source: this._repo.Query().OrderBy( p => p.ID ),
			request: Request, 
			startAt: pagination.StartAt, 
			maxResults: pagination.MaxResults 
		);
    }
}