using MudBlazor;
using MudBlazor.Services;
using RookieDriver.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMudServices(config =>
    {
        config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
    })
    .AddRazorComponents()
    .AddInteractiveServerComponents();

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
    .AddInteractiveServerRenderMode();

app.Run();
