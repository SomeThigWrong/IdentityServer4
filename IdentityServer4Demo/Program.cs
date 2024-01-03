using IdentityServer4Demo.IdentityConfiguration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddIdentityServer()
    .AddInMemoryClients(Clients.Get())
    .AddInMemoryIdentityResources(Resources.GetIdentityResources())
    .AddInMemoryApiResources(Resources.GetApiResources())
    .AddInMemoryApiScopes(Scopes.GetApiScopes())
    .AddTestUsers(Users.Get())
    .AddDeveloperSigningCredential();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();
app.UseIdentityServer();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

app.Run();
