global using Syncfusion.Blazor;
using SyncfusionBlazorApp.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SyncfusionBlazorApp;

// Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Njc2MTQ1QDMyMzAyZTMyMmUzMFdvczJlSGk1MGt6SXEvY0ZONUhLd0tpU1hNeGtqNHVBNHJvVVYxWGx4V2s9");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<PdfService>();
builder.Services.AddSingleton<ExcelService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
