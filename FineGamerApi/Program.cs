using Api.ConfigurationDI;

using Core.Contracts.Repositories;
using EF.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.AddDI(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDirectoryBrowser();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Total",
        builder =>
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Total");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
