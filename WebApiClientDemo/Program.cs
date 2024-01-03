using WebAPIDemo.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IIdentityServer4Service,IdentityServer4Service>();
builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); 
}

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
