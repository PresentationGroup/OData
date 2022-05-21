using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using ODataAlternateKeySample.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Fetching Connection string from APPSETTINGS.JSON  
var ConnectionString = "";

//Entity Framework  
builder.Services.AddDbContext<ODataAlternateKeySample.Models.DB.TestContext>(options => options.UseSqlServer("Data Source=.;Initial Catalog=Test;Integrated Security=True"));

builder.Services.AddTransient<IAlternateKeyRepository, AlternateKeyRepositoryInMemory>();
builder.Services.AddControllers().
    AddOData(opt => opt.EnableQueryFeatures()
        .AddRouteComponents("api", EdmModelBuilder.GetEdmModel()));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseODataRouteDebug();

app.UseAuthorization();

app.MapControllers();

app.Run();
