using Microsoft.AspNetCore.Mvc;
namespace School.REST.Controllers.V1;

using School.DAL;
using School.Models;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]"), Route("api/latest/[controller]")]
public class StudentController : AtomicController<Student>
{
	public StudentController( IRepository<Student> repo  ) : base( repo ) {}

    [HttpPost, Route("")]
    public virtual Response<Student> Add( Student data )
    {
		var person = new Student{
			FirstName = data.FirstName,
			LastName = data.LastName,
			EnrollmentDate = data.EnrollmentDate
		};

		this._repo.Add( person );

		return new Response<Student>(person);
    }
}