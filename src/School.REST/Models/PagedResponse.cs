namespace School.REST.Models;

public class PagedResponse<T> : Response<ICollection<T>>
{
	public Pagination Pagination { get; }

	private PagedResponse( ICollection<T> items, HttpRequest request, int totalItemCount, int startAt, int maxResults ) : base( items )
	{
		this.Pagination = new Pagination( request ) {
			Total = totalItemCount,
			MaxResults = maxResults,
			StartAt = startAt
		};
	}

	public static PagedResponse<T> ToPagedResponse( IQueryable<T> source, HttpRequest request, int startAt, int maxResults )
    {
        var count = source.Count();
        var items = source.Skip( startAt ).Take( maxResults ).ToList();
		
        return new PagedResponse<T>( items, request, count, startAt, maxResults );
    }
}