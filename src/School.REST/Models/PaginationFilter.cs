namespace School.REST.Models;

public class PaginationFilter
{
	const int MAX_RESULTS = 1000;

	private int _maxResults = 10;
	public int MaxResults { 
		get => _maxResults; 
		set => _maxResults = Math.Min( Math.Max( Math.Abs( value ), 1 ), MAX_RESULTS );
	}

	private int _startAt = 0;
	public int StartAt { 
		get => _startAt; 
		set => _startAt = Math.Abs( value );
	}	
}

// Extend query mutator
static public class PaginationQueryMutator 
{
	static public QueryMutator SetStartAt( this QueryMutator mutator, int offset )
	{
		offset = Math.Max( offset, 0 );

		if( offset > 0 )
			mutator.Replace( "StartAt", offset );
		else 
			mutator.Remove( "StartAt" );

		return mutator;
	}	

	static public QueryMutator SetMaxResults( this QueryMutator mutator, int maxResults ) => mutator.Replace( "MaxResults", maxResults );
}
