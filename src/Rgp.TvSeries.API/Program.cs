using Rgp.TvSeries.API.MigrationManager;
using Rgp.TvSeries.Bootstrap;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.SwaggerDoc("TvSeriesOpenAPISpecification", new()
    {
        Title = "TV Series API",
        Version = "v1",
        Description = "Through this API you can manage your TV Shows!",
        Contact = new()
        {
            Name = "Rodrigo Pereira",
            Url = new Uri("https://github.com/rpereira12")
        }
    });

    var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlCommentsFullPath = Path.Combine(
        AppContext.BaseDirectory, xmlCommentsFile);

    setupAction.IncludeXmlComments(xmlCommentsFullPath);
});

ServicesConfiguration.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/TvSeriesOpenAPISpecification/swagger.json",
        "TV Series API");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase();
app.Run();
