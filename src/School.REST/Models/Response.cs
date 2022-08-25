namespace School.REST.Models;

public class Response<T>
{
	public bool Succeeded { get; set; }
	public T? Data { get; set; }
	public string[]? Errors { get; set; }

	public Response( T data )
	{
		this.Succeeded = true;
		this.Data = data;
	}

	public Response( string error ) : this( new string[]{ error } ){ }

	public Response( string[] errors )
	{
		this.Succeeded = false;
		this.Errors = errors;
	}
}