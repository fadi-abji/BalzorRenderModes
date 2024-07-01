using BalzorRenderModes.Api;
using BlazorRenderModes.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;



var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ICounterApi, CounterApi>();

builder.Services.AddScoped<CounterClientService>();

await builder.Build().RunAsync();
