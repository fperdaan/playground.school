namespace School.REST.Models;

public class Pagination
{
	private HttpRequest _request;

	public Pagination( HttpRequest request )
	{
		this._request = request;
	}

	public int Total { get; set; }
	public int MaxResults { get; set; }
	public int StartAt { get; set; }

	public string? PrevPage { 
		get {
			if( this.StartAt <= 0 )
				return null;

			QueryMutator request = new QueryMutator( this._request );
			
			request.SetStartAt( this.StartAt - this.MaxResults );

			return request.ToString();
		}
	}
	public string? NextPage { 
		get {
			if( this.MaxResults + this.StartAt >= this.Total )
				return null;

			QueryMutator request = new QueryMutator( this._request );
			request.SetStartAt( this.StartAt + this.MaxResults );

			return request.ToString();
		}
	}
}