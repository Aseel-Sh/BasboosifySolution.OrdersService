using Basboosify.OrdersMicroservice.BusinessLogicLayer;
using Basboosify.OrdersMicroservice.DataAccessLayer;
using Basboosify.OrdersMicroservice.API.Middleware;

using FluentValidation.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

//add DAL and BLL services

builder.Services.AddDataAccessLayer(builder.Configuration);
builder.Services.AddBusinessLogicLayer(builder.Configuration);

builder.Services.AddControllers();

//fluent validations
builder.Services.AddFluentValidationAutoValidation();

//add swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(builder => {
        builder.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseMiddleware();
app.UseRouting();

//Cors
app.UseCors();

//swagger
app.UseSwagger();
app.UseSwaggerUI();

//auth
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

//endpoints
app.MapControllers();

app.Run();
