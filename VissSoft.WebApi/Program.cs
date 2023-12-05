using Microsoft.EntityFrameworkCore;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;
using VissSoft.Infrastracture.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<VissSoftDbContext>(options =>
    options.UseMySql(connectionString,
    ServerVersion.AutoDetect(connectionString)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<VissSoftDbContext, VissSoftDbContext>();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
