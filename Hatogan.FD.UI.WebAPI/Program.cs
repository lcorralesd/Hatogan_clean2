using Hatogan.FD.UI.WebAPI.Extensions;
using Hatogan.IA.IoC;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddHatoganServices(configuration);
builder.Services.ApiVersioningExtension();
builder.Services.ConfigureCORS();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Hatogan.FD.UI.WebAPI", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hatogan.FD.UI.WebAPI v1");
        c.DisplayRequestDuration();
    });
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.UseExceptionHandlerMiddleware();

app.MapControllers();

app.Run();
