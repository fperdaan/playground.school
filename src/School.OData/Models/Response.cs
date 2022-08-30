using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace School.OData.Models;

public class Response<T> : IConvertToActionResult
{
	public HttpStatusCode Code { get; set; }
	public T? Data { get; set; }

	public Response()
	{
		this.Code = HttpStatusCode.OK;
	}

	public Response( T data ) : this()
	{
		this.Data = data;
	}
	
	// public virtual async Task ExecuteResultAsync( ActionContext context )
	// {
	// 	var result = new ObjectResult( this ) { 
	// 		StatusCode = this.Code == HttpStatusCode.NotFound ? 200 : (int)this.Code 
	// 	};

    //     await result.ExecuteResultAsync( context );
	// }

	public IActionResult Convert()
	{
		return new ObjectResult( this ) { 
			StatusCode = this.Code == HttpStatusCode.NotFound ? 200 : (int)this.Code 
		};
	}
}