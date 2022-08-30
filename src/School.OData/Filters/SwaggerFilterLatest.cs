
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace School.OData.Filters;

public class SwaggerFilterLatest : IDocumentFilter
{
	public void Apply( OpenApiDocument swaggerDoc, DocumentFilterContext context )
	{
		var remove = swaggerDoc.Paths
						.Where( kp => kp.Key.Contains("api/latest") )
						.Select( kp => kp.Key )
						.ToList();

		foreach( string key in remove )
		{
			swaggerDoc.Paths.Remove( key );
		}
	}
}