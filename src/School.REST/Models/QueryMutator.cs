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
	public QueryMutator Add( string name, int value ) => Add( name, value.ToString() );
	public QueryMutator Add( string name, double value ) => Add( name, value.ToString() );
	public QueryMutator Add( string name, float value ) => Add( name, value.ToString() );

	public QueryMutator Remove( string name )
	{
		this._query.Remove( name );

		return this;
	}	

	public QueryMutator Replace( string name, string value )
	{
		return this.Remove( name ).Add( name, value );
	}	

	public QueryMutator Replace( string name, int value ) => Replace( name, value.ToString() );
	public QueryMutator Replace( string name, double value ) => Replace( name, value.ToString() );
	public QueryMutator Replace( string name, float value ) => Replace( name, value.ToString() );

	public override string? ToString()
	{	
		var uri = this._uri.ToString().Split('?', 2)[0];
		var query = this._query.ToString();

		if( string.IsNullOrWhiteSpace( query ) ) 
			return uri + this._uri.Fragment;
		else 
			return uri + "?" + query + this._uri.Fragment;
	}
}