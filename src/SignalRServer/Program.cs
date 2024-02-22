using SignalRServer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureServices();
var app = builder.Build();
var env = app.Environment;
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapHub<ChatHub>("/chatHub");
app.UseStaticFiles();
app.Run();
