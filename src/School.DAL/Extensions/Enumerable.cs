namespace School.DAL.Extensions;

static public class Enumerable
{
	static public IEnumerable<TSource> SelectIf<TSource>( this IEnumerable<TSource> source, bool condition, Func<TSource, TSource> selector )
	{
		if( condition )
			return source.Select( selector );

		else 
			return source;
	}
}