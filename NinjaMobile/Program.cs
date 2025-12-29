using MudBlazor.Services;
using NinjaMobile.Components;

var builder = WebApplication.CreateBuilder(args);
//For linux server
//builder.WebHost.UseUrls("http://0.0.0.0:5003");


// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddMudServices();

// ⭐ your API base URL
//var apiBaseUrl = "https://localhost:7238/api/";
//var apiBaseUrl = "https://localhost:7238/api/";
//builder.Services.AddScoped(sp => new HttpClient
//{
//    BaseAddress = new Uri(apiBaseUrl)
//});
// end 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
