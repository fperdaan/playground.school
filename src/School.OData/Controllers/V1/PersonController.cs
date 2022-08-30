using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using School.DAL;
using School.Models;

namespace School.OData.Controllers.V1;

[ApiVersion("1.0")]
public partial class PersonController : ODataController
{	
	private IRepository<Person> _repo;

	public PersonController( IRepository<Person> repo )
	{
		this._repo = repo;
	}

	[EnableQuery(PageSize=10)]
	public virtual IQueryable<Person> Get()
	{
		return this._repo.Query();
	}

	[EnableQuery]
	public virtual SingleResult<Person> Get( int key )
	{
		IQueryable<Person> result = this._repo.Query()
											.Where( p => p.ID == key );

		return SingleResult.Create( result );
	}
}