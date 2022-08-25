using Microsoft.Extensions.DependencyInjection;

using School.Models;

namespace School.DAL;

static public class Configure 
{
	public static void ConfigureServices( IServiceCollection services  )
	{
		services
			.AddScoped<IRepository<Student>, AtomicRepository<Student>>()
			.AddScoped<IRepository<Teacher>, AtomicRepository<Teacher>>()
			.AddScoped<IRepository<Person>, AtomicRepository<Person>>();

		// services
		// 		.AddDbContext<HPlusSportsContext>(options => options.UseSqlite(connectionString));

		// services
		// 	.AddScoped<IOrderRepository, OrderRepository>()
		// 	.AddScoped<IRepository<Customer>, AtomicRepository<Customer>>()
		// 	.AddScoped<IRepository<Product>, AtomicRepository<Product>>()
		// 	.AddScoped<ISalesPersonRepository, SalesPersonRepository>()
		// 	.AddScoped<ITrackingRepository<SalesGroup>, TrackingRepository<SalesGroup>>();
	}
}