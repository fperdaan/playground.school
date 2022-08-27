using System.Net;

namespace School.REST.Models;

public class Response<T>
{
	public HttpStatusCode Code { get; set; }
	public T? Data { get; set; }
	public string[]? Errors { get; set; }

	public Response( T data )
	{
		this.Code = HttpStatusCode.OK;
		this.Data = data;
	}

	public Response( string error ) : this( new string[]{ error } ){ }

	public Response( string[] errors, HttpStatusCode code = HttpStatusCode.BadRequest )
	{
		this.Code = code;
		this.Errors = errors;
	}
}