using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace School.REST.Models;

public class ErrorResponse<T> : Response<T>
{
	public IDictionary<string, string[]>? Errors { get; set; }

	#region Error constructors
	public ErrorResponse( IDictionary<string, string[]> errors, HttpStatusCode code = HttpStatusCode.BadRequest ) : base()
	{
		this.Code = code;
		this.Errors = errors;
	}

	public ErrorResponse( string error, HttpStatusCode code = HttpStatusCode.BadRequest ) : this( new string[]{ error }, code ){ }
	public ErrorResponse( string param, string error, HttpStatusCode code = HttpStatusCode.BadRequest ) : this( new Dictionary<string, string[]>(){ { param, new string[]{ error } } }, code ){ }
	public ErrorResponse( string[] errors, HttpStatusCode code = HttpStatusCode.BadRequest ) : this( new Dictionary<string, string[]>(){ { "request", errors } }, code ) { }

	public ErrorResponse( ValidationProblemDetails validationDetails ) : this( validationDetails.Errors ) {} 

	#endregion
}