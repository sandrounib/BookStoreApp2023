using BookStore.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddSwaggerGen();
//builder.Services.AddControllers();
builder.Services.AddDatabase(builder.Configuration);

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
