using Microsoft.AspNetCore.Mvc;

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
    public ActionResult<Person> Get( int id )
    {	
		T? result = this._repo.GetById( id ).Result;

		if( result != null )
			return Ok( result );

		else 
			return NotFound();
    }

    [HttpGet, Route("")]
    public Task<IEnumerable<T>> List()
    {
		return this._repo.GetAll();
    }

}