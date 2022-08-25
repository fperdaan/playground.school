using Microsoft.AspNetCore.Mvc;

using School.Models;
using School.DAL;

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
    public Task<IEnumerable<Person>> List()
    {
		return this._repo.GetAll();
    }

}