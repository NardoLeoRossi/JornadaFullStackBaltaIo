using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Fina.Web;
using Fina.Web.Handlers;
using Fina.Core;
using Fina.Core.Handlers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddHttpClient(WebConfiguration.HttpClientName,
    opt =>
    {
        opt.BaseAddress = new Uri(Configuration.BackendUrl);
    });

builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();

await builder.Build().RunAsync();
