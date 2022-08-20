var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); //���������� ����������� ���-API ������������
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //������ Swagger

var app = builder.Build();

// �������� � ������ ������� ���������� � ������ ����������
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); //������ �����������

app.MapControllers(); //��������� �������� ������������ API ��� �������� �����

app.Run(); //������ ����������
