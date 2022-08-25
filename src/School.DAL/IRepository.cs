using School.Models;
using System.Linq.Expressions;

namespace School.DAL;

public interface IRepository<T> where T : IStorable
{
	public Task Add( T item );
	public Task AddAll( IEnumerable<T> items );
	public Task Delete( int id );
	public Task<IEnumerable<T>> Get<T2>( Expression<Func<T, bool>> predicate );
	public Task<IEnumerable<T>> GetAll();
	public Task<T?> GetById( int id );
	public Task Save( T item );
	public Task SaveAll( IEnumerable<T> items );
}