using Microsoft.AspNetCore.Mvc;
namespace School.REST.Controllers.V1;

using School.DAL;
using School.Models;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]"), Route("api/latest/[controller]")]
public class TeacherController : AtomicController<Teacher>
{
	public TeacherController( IRepository<Teacher> repo  ) : base( repo ) {}

    [HttpPost, Route("")]
    public Teacher Add( Teacher data )
    {
		var person = new Teacher{
			FirstName = data.FirstName,
			SirName = data.SirName,
			Topics = data.Topics
		};

		this._repo.Add( person );

		return person;
    }
}