using Microsoft.AspNetCore.Mvc;

using School.Models;
using School.DAL;

namespace School.REST.Controllers;

[ApiController, ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/sample"), Route("api/latest/sample")]
public class Sample : ControllerBase
{
	private IRepository<Student> _studentRepo;

	public Sample( IRepository<Student> studentRepo )
	{
		this._studentRepo = studentRepo;
	}

    [HttpGet, Route("list")]
    public async Task<IEnumerable<Student>> Get()
    {
		return await this._studentRepo.GetAll();
    }
}