namespace School.REST.Models;

public class PaginationFilter
{
	public int MaxResults { get; set; } = 10;
	public int StartAt { get; set; } = 0;	
}

static public class PaginationQueryMutator 
{
	static public QueryMutator SetStartAt( this QueryMutator mutator, int offset )
	{
		offset = Math.Max( offset, 0 );

		if( offset > 0 )
			mutator.Replace( "StartAt", offset.ToString() );
		else 
			mutator.Remove( "StartAt" );

		return mutator;
	}	

	static public QueryMutator SetMaxResults( this QueryMutator mutator, int maxResults ) => mutator.Replace( "MaxResults", maxResults.ToString() );
}
