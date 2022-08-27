global using School.REST.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using School.REST.Configuration;

var builder = WebApplication.CreateBuilder(args);


# region configure services 

// Configure default services

builder.Services.AddControllers()
					.AddNewtonsoftJson( o => {
						o.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
						o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
						//o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
						//o.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
					});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRouting( options => options.LowercaseUrls = true );

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
School.BL.Configure.ConfigureServices( builder.Services );


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

// School.BL.Fluent.Campus
// 	.Construction
// 		.AddBuilding("Building 3");

app.Run();


# endregion




// Fluent sample
/*
Campus
	.Construction
		.AddBuilding("Building 3")
			.AddRoom("Room 102")
				.TeachTopics( Topic.Math )
				.TeachTopcis( Topic.Language )
			.Apply()
			.AddRoom("Room 103")
				.TeachTopics( Topic.Science )
			.Apply()
		.ModifyBuilding("Building 2")
			.RemoveRoom("Room 101")
			.ModifyRoom("Room 102")
				.TeachTopic( Topic.Math )
			.Apply()
		.Construct()
		*/