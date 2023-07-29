using Leduca.API.Extensions;
using Leduca.API.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer().ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
builder.Services.AddSwaggerGen();
builder.AddRequiredServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};


app.MapGet("/books", async ([FromServices] IBookService bookService) =>
{
    return await bookService.GetAllBooksAsync();
})
.WithName("GetBooks")
.WithOpenApi();

app.MapGet("/bookquizzes", async ([FromServices] IBookService bookService) =>
{
    return await bookService.GetAllQuizesAsync();
})
.WithName("GetBookQuizzes")
.WithOpenApi();

app.Run();

