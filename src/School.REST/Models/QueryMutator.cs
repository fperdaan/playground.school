using Microsoft.AspNetCore.Http.Extensions;

using System.Web;
using System.Collections.Specialized;

namespace School.REST.Models;

public class QueryMutator
{
	private Uri _uri;
	private NameValueCollection _query;

	public QueryMutator( HttpRequest request ) : this( new Uri( request.GetDisplayUrl() ) ) {}

	public QueryMutator( Uri uri )
	{
		this._uri = uri;
		this._query = HttpUtility.ParseQueryString( uri.Query );
	}

	public QueryMutator Add( string name, string value )
	{
		this._query.Add( name, value );

		return this;
	}

	public QueryMutator Remove( string name )
	{
		this._query.Remove( name );

		return this;
	}	

	public QueryMutator Replace( string name, string value )
	{
		return this.Remove( name ).Add( name, value );
	}	

	public override string? ToString()
	{	
		var uri = this._uri.ToString().Split('?', 2)[0];
		var query = this._query.ToString();

		if( query != "" ) 
			return uri + "?" + query + this._uri.Fragment;

		else 
			return uri + this._uri.Fragment;
	}
}