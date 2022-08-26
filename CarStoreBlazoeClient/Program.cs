using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using CarStoreBlazoeClient;
using CarStoreBlazoeClient.Service;
using CarStoreBlazoeClient.Service.IHttpService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IProductClientService,ProductClientService>();
builder.Services.AddScoped<IOrderClientService,OrderClientService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorise(opt =>
{
    opt.Immediate = true;

}).AddBootstrapProviders()
.AddFontAwesomeIcons();
await builder.Build().RunAsync();
