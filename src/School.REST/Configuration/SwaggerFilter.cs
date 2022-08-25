
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace School.REST.Configuration;

public class SwaggerFilter : IDocumentFilter
{
	public void Apply( OpenApiDocument swaggerDoc, DocumentFilterContext context )
	{
		var remove = swaggerDoc.Paths
						.Where( kp => kp.Key.Contains("/latest/") )
						.Select( kp => kp.Key )
						.ToList();

		foreach( string key in remove )
		{
			swaggerDoc.Paths.Remove( key );
		}
	}
}