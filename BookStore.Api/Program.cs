using BookStore.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDatabase(builder.Configuration);
//builder.Services.AddMediatorExtension();

var app = builder.Build();

//TODO: FUNCIONOU O SWAGGER DEPOIS DO IF ABAIXO

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
