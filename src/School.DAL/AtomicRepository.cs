using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

using School.Models;

namespace School.DAL;

public partial class AtomicRepository<T> : IRepository<T> where T : StorableEntity
{
	private SchoolStorageContext _context;

	public AtomicRepository( SchoolStorageContext context )
	{
		this._context = context;
	}

	public virtual async Task Add( T item )
	{
		this._context.Add( item );

		await this._context.SaveChangesAsync();
	}

	public virtual async Task AddAll( IEnumerable<T> items )
	{
		this._context.AddRange( items );

		await this._context.SaveChangesAsync();
	}

	public virtual async Task Delete( int id )
	{
		T? obj = await this.GetById( id );

		if( obj != null )
		{
			this._context.Remove( obj );

			await this._context.SaveChangesAsync();
		}
	}

	public IQueryable<T> FindAll()
	{
		return _context.Set<T>();
	}

	public virtual async Task<IEnumerable<T>> Get<T2>( Expression<Func<T, bool>> predicate )
	{
    	return await _context.Set<T>().AsNoTracking().Where( predicate ).ToListAsync();
	}

	public virtual async Task<IEnumerable<T>> GetAll()
	{
        return await _context.Set<T>().AsNoTracking().ToListAsync();
	}

	public virtual async Task<T?> GetById( int id )
	{
		return await this._context.Set<T>().FindAsync( id );
	}

	public virtual async Task Save( T item )
	{
		this._context.Update( item );

		await this._context.SaveChangesAsync();
	}

	public virtual async Task SaveAll( IEnumerable<T> items )
	{
		this._context.UpdateRange( items );

		await this._context.SaveChangesAsync();
	}
}