//using DeveloperTicket.DAL;
//using Microsoft.EntityFrameworkCore;

using DeveloperTicket.BL;
using DeveloperTicket.DAL;
using DeveloperTicket.DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//database
builder.Services.AddDbContext<TicketDevContext>(Option =>
{
    Option.UseSqlServer(builder.Configuration.GetConnectionString("TicketCS"));
});

//Repos
builder.Services.AddScoped<IDepartmentRepo,DepartmentRepo>();
builder.Services.AddScoped<IDepartmentManager,DepartmentManager>();





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

app.Run();
