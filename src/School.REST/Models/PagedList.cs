namespace School.REST.Models;

public class PagedList<T>
{
	public Pagination Pagination { get; }
	public ICollection<T> List { get; }

	private PagedList( ICollection<T> items, HttpRequest request, int totalItemCount, int startAt, int maxResults )
	{
		this.Pagination = new Pagination( request ) {
			Total = totalItemCount,
			MaxResults = maxResults,
			StartAt = startAt
		};

		this.List = items;
	}

	public static PagedList<T> ToPagedList( IQueryable<T> source, HttpRequest request, int startAt, int maxResults )
    {
        var count = source.Count();
        var items = source.Skip( startAt ).Take( maxResults ).ToList();
		
        return new PagedList<T>( items, request, count, startAt, maxResults );
    }
}