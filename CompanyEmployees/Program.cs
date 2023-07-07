using CompanyEmployees.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) 
    app.UseDeveloperExceptionPage();
else 
    app.UseHsts();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();