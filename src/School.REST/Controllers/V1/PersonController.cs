using Microsoft.AspNetCore.Mvc;
namespace School.REST.Controllers.V1;

using School.DAL;
using School.Models;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]"), Route("api/latest/[controller]")]
public class PersonController : AtomicController<Person>
{
	public PersonController( IRepository<Person> repo  ) : base( repo ) {}
}