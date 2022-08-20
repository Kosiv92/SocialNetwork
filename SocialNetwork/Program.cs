var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); //добавление функционала веб-API контроллеров
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //сервис Swagger

var app = builder.Build();

// действия в случае запуска приложения в режиме разработки
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); //сервис авторизации

app.MapControllers(); //настройка действий контроллеров API как конечных точек

app.Run(); //запуск приложения
