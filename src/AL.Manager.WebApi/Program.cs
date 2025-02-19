using AL.Manager.Aplication.Interface;
using AL.Manager.Aplication.Interface.Base;
using AL.Manager.Aplication.Services;
using AL.Manager.Aplication.Services.Base;
using AL.Manager.Domain.Interface;
using AL.Manager.Domain.Interface.Base;
using AL.Manager.Infra.Data.Context;
using AL.Manager.Infra.Data.Repositories;
using AL.Manager.Infra.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options=>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),b => b.MigrationsAssembly("AL.Manager.Infra.Data"))
);
builder.Services.AddScoped<IMemberService,MemberService>();
builder.Services.AddScoped<IMemberRepository,MemberRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

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
