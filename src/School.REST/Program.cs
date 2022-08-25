using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

using Microsoft.EntityFrameworkCore;

using School.REST.Configuration;

var builder = WebApplication.CreateBuilder(args);


# region configure services 

// Configure default services

builder.Services.AddControllers()
					.AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning();
builder.Services.AddApiVersioning(options =>
{
	options.DefaultApiVersion = new ApiVersion( 1, 0 );
	options.AssumeDefaultVersionWhenUnspecified = true;
	options.ReportApiVersions = true;
});

builder.Services.AddVersionedApiExplorer(setup =>
{
	setup.GroupNameFormat = "'v'VVV";
	setup.SubstituteApiVersionInUrl = true;
});

builder.Services.ConfigureOptions<SwaggerOptions>();
builder.Services.AddSwaggerGen( c => {
	c.DocumentFilter<SwaggerFilter>(); 
});

// Set database context
builder.Services
			.AddDbContext<School.DAL.SchoolStorageContext>( 
				c => c.UseSqlite( 
					builder.Configuration.GetConnectionString("DefaultConnection"), 
					b => b.MigrationsAssembly("School.REST") 
				) );


// Configure sub services
School.DAL.Configure.ConfigureServices( builder.Services );

# endregion

# region Setup app 

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
	var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

	app.UseSwagger();
	app.UseSwaggerUI( options => {
		// Build a swagger endpoint for each discovered API version  
		foreach ( var description in apiVersionDescriptionProvider.ApiVersionDescriptions )  
		{  
			options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant() );  
		}  
	});
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();

# endregion