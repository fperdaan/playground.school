using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace School.OData.Filters;

public class SwaggerVersionProvider : IConfigureNamedOptions<SwaggerGenOptions>
{
	private readonly IApiVersionDescriptionProvider _provider;

	public SwaggerVersionProvider( IApiVersionDescriptionProvider provider )
	{
		this._provider = provider;
	}

	public void Configure( SwaggerGenOptions options )
	{
		// add swagger document for every API version discovered
		foreach ( var description in _provider.ApiVersionDescriptions )
		{
			options.SwaggerDoc( description.GroupName, CreateVersionInfo( description ) );
		}
	}

	public void Configure( string name, SwaggerGenOptions options ) => Configure( options );

	private OpenApiInfo CreateVersionInfo( ApiVersionDescription description )
	{
		var info = new OpenApiInfo(){
			Title = "School.OData",
			Version = description.ApiVersion.ToString()
		};

		if ( description.IsDeprecated )
		{
			info.Description += " This API version has been deprecated.";
		}

		return info;
	}
}