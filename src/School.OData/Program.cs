using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;
using Microsoft.OData.Edm;

using School.Models;
using School.OData.Filters;
using School.OData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

# region Setup configuration and services

// Add services to the container.

builder.Services.AddControllers()
					.AddJsonOptions( options => 
					{
						options.JsonSerializerOptions.PropertyNamingPolicy = null;
					})
					.AddOData( options => 
					{
						var builder = new ODataConventionModelBuilder();

						builder.EntitySet<Person>("Person");

						IEdmModel model = builder.GetEdmModel();

						// should probably read 
						options.EnableQueryFeatures( 250 );
						options.AddRouteComponents( "api/v{version}", model ); 
						options.AddRouteComponents( "api/latest", model ); 
					});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

# region Swagger support
//builder.Services.ConfigureOptions<SwaggerVersionProvider>();
builder.Services.AddSwaggerGen( context => 
{
	context.DocumentFilter<SwaggerFilterLatest>(); 
});

builder.Services.AddRouting( options => options.LowercaseUrls = true );

builder.Services.AddApiVersioning( options =>
{
	options.DefaultApiVersion = new ApiVersion( 1, 0 );
	options.AssumeDefaultVersionWhenUnspecified = true;
	options.ReportApiVersions = true;
});

// Handle thrown errors
builder.Services.Configure<ApiBehaviorOptions>( options => 
{
    options.InvalidModelStateResponseFactory = context => new ResponseError<bool>( new ValidationProblemDetails( context.ModelState ) ).Convert();
});


// -- Upon enabling this we lose our swagger doc
// builder.Services.AddVersionedApiExplorer( setup =>
// {
// 	setup.GroupNameFormat = "'v'VVV";
// 	setup.SubstituteApiVersionInUrl = true;
// });

# endregion

// Set database context
builder.Services
			.AddDbContext<School.DAL.SchoolStorageContext>( 
				c => c.UseSqlite( 
					builder.Configuration.GetConnectionString("DefaultConnection"), 
					b => b.MigrationsAssembly("School.OData") 
				) );


// Configure sub services
School.DAL.Configure.ConfigureServices( builder.Services );
School.BL.Configure.ConfigureServices( builder.Services );

# endregion
# region Setup app

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI( options => 
	{
		// Disable scheme section
		options.DefaultModelsExpandDepth(-1);

		// var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

		// // Build a swagger endpoint for each discovered API version  
		// foreach ( var description in apiVersionDescriptionProvider.ApiVersionDescriptions )  
		// {  
		// 	options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant() );  
		// } 

		options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
	});
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

# endregion

app.Run();
