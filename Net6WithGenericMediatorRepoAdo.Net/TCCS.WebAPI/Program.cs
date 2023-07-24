using TCCS.Commands;
using TCCS.Commands.Command.Employee;
using TCCS.Commands.Handlers.EmployeeHandlers;
using TCCS.Commands.Models.EmployeeModel.Response;
using TCCS.Commands.Queries.Employee;
using TCCS.Data.Inerfaces;
using TCCS.Data.Models;
using TCCS.Data.Repositories;
using TCCS.Data.SqlConnections;
using TCCS.Data.SqlConnections.Interfaces;
using TCCS.Domain.Interfaces;
using TCCS.Domain.Repositories;
using TCCS.WebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IMediator, Mediator>();
builder.Services.AddConfiguration<DatabaseConnectionWithoutCredentials>("DatabaseConnectionWithoutCredentials");
builder.Services.Configure<DatabaseConnectionWithoutCredentials>(builder.Configuration.GetSection("DatabaseConnectionWithoutCredentials"));


builder.Services.AddScoped<ISqlCommandWrapper, SqlCommandWrapper>();
builder.Services.AddScoped<ISqlConnectionProvider, SqlConnectionProvider>();


builder.Services.AddScoped<IRepository,Repository>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IQueryHandler<GetEmployeeListQuery,GetEmployeeListReponse>,GetEmployeeListQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetEmployeeByIdQuery, GetEmployeeByIdReponse>, GetEmployeeByIdQueryHandler>();
builder.Services.AddScoped<IQueryHandler<CreateEmployeeCommand, CreateEmployeeResponse>, CreateEmployeeCommandHandler>();
builder.Services.AddScoped<IQueryHandler<UpdateEmployeeCommand, UpdateEmployeeResponse>, UpdateEmployeeCommandHandler>();
builder.Services.AddScoped<IQueryHandler<DeleteEmployeeCommand, DeleteEmployeeResponse>, DeleteEmployeeCommandHandler>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
