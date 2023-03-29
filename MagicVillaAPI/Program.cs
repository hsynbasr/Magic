using MagicVillaAPI.Logging;
using MagicVillaAPI.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//                    .WriteTo.File("log/villalogs.txt", rollingInterval: RollingInterval.Day)
//                    .MinimumLevel.Debug().WriteTo.Console().CreateLogger();
//builder.Host.UseSerilog();

builder.Services.AddScoped<ILogging,LogingV2>();
//builder.Services.AddSingleton<ILogging, Logging>();
//builder.Services.AddTransient<ILogging, Logging>();



//builder.Services.AddTransient<IMailService, LocalMailService>();
builder.Services.AddTransient<IMailService, LocalMailService>();




//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();


builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

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
