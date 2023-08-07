using MamsLeagueApi.App_Start;
using MamsLeagueApi.Extention;
using MamsLeagueApi.Shared.Helpers;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//enable cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins", 
        builder => builder.AllowAnyOrigin().
        AllowAnyMethod().AllowAnyHeader());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureDomainLeagueExtention(builder.Configuration);

builder.Services
        .AddMvc(opt => opt.Filters.Add(typeof(DBSaveChangesFilter)))
        .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyAllowSpecificOrigins");

app.UseAuthorization();

app.UseHttpsRedirection();



app.UseMiddleware<ErrorHandlerMiddleware>();

app.MapControllers();

app.Run();
