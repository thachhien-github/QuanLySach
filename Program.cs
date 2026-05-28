using QuanLySach;

var builder = WebApplication.CreateBuilder(args);

// Instantiate Startup and call ConfigureServices
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Call Configure in Startup
startup.Configure(app, app.Environment);

app.Run();

