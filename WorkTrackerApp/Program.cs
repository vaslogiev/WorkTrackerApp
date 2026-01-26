using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Supabase;
using WorkTrackerApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(provider =>
    new Client(
        "https://rxvuylvhbsoepnclbaiw.supabase.co",
        "sb_publishable_XssO8nOqlteCn7eUpjOp1g_LaGRnrZH",
        new SupabaseOptions 
        {
          AutoRefreshToken = true,
          AutoConnectRealtime = true
        }
    )
);

await builder.Build().RunAsync();
