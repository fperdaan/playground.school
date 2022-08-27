using Microsoft.Extensions.DependencyInjection;
using School.BL.Fluent;

namespace School.BL;

static public class Configure 
{
	public static void ConfigureServices( IServiceCollection services  )
	{
		services
			.AddTransient<IFluentBuilding, FluentBuilding>();

		//	.AddTransient<IFluentClassroom, FluentClassroom>();
	}
}