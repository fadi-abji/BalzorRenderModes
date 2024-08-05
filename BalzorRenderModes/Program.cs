using BalzorRenderModes.Api;
using BalzorRenderModes.Components;
using BalzorRenderModes.Services;
using BlazorRenderModes.Client.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()// to active the interactiverenderservermode  
    .AddInteractiveWebAssemblyComponents();

// Adding Api Controller
builder.Services.AddControllers();
// Adding a service to comnicate with a controller
builder.Services.AddScoped<ICounterService, CounterService>();
builder.Services.AddScoped<ICounterApi, CounterServerSide>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode() // To active the interactiverenderservermode, then you go to the page and type this @rendermode InteractiveServer
    .AddInteractiveWebAssemblyRenderMode();
    //.AddAdditionalAssemblies(typeof(RenderModeTestApi).Assembly);

app.Run();
