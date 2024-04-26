using Microsoft.AspNetCore.Authentication.Cookies;
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Services;
using OdiAdmin.Services.OdiUsers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<ClientSettings>(builder.Configuration.GetSection("ClientSettings"));
builder.Services.Configure<ServiceApiSettings>(builder.Configuration.GetSection("ServiceApiSettings"));
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IApiHandler, ApiHandler>();
builder.Services.AddOdiServices(builder.Configuration);

builder.Services.AddScoped<ResourceOwnerPasswordTokenHandler>();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, opts =>
{
    opts.LoginPath = "/giris";
    opts.ExpireTimeSpan = TimeSpan.FromDays(30);
    opts.SlidingExpiration = true;
    opts.Cookie.Name = "odiCookie";
});
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
