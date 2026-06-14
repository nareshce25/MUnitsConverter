using MUnitsConverter.Middleware;
using MUnitsConverter.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IConversionService, ConversionService>();
builder.Services.AddScoped<ILengthConversionService, LengthConversionService>();
builder.Services.AddScoped<ITemperatureConversionService, TemperatureConversionService>();
builder.Services.AddScoped<IWeightConversionService, WeightConversionService>();


var app = builder.Build();
app.UseExceptionHandling();

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
