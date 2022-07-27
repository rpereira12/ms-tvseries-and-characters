using Microsoft.EntityFrameworkCore;
using Rgp.TvSeries.API.MigrationManager;
using Rgp.TvSeries.Data.V1.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");
builder.Services.AddDbContext<TvSeriesDbContext>(opts =>
        opts.UseSqlServer(connectionString,
            options => options.MigrationsAssembly("Rgp.TvSeries.API")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase();
app.Run();
