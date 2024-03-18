using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineShop2.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<ICustomersService, CustomersApiService>();


await builder.Build().RunAsync();
