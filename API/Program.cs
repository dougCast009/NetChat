using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
string connectionString = "Data Source=netchat.db";
builder.Services.AddDbContext<DataContext>(o =>
{
    o.UseSqlite(connectionString);
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    try {
        var context = services.GetRequiredService<DataContext>();
        context.Database.EnsureDeleted();
        context.Database.Migrate();
    }
    catch (Exception ex){
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Ocurrio un error durante la migracion");
    }
}

app.UseAuthorization();

app.MapControllers();

app.Run();
