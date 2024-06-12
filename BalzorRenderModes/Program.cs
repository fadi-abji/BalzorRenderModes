using BalzorRenderModes.Components;
using BlazorRenderModes.Client.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()// to active the interactiverenderservermode  
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode() // To active the interactiverenderservermode, then you go to the page and type this @rendermode InteractiveServer
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(RenderModeTest).Assembly); 

app.Run();
