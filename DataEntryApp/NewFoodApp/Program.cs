using NewFoodApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>  
{
    options.Cookie.Name = "hotelbusiness.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddOutputCache(options =>
{
    options.AddBasePolicy(builder =>
        builder.Expire(TimeSpan.FromSeconds(5)));

    options.AddPolicy("CacheForTenSeconds", builder =>
        builder.Expire(TimeSpan.FromSeconds(10)));

    options.AddPolicy("CacheFor40Seconds", builder =>
       builder.Expire(TimeSpan.FromSeconds(40)));

});

builder.Services.AddSingleton<IFoodService, FoodService>();

builder.Services.AddOutputCache();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseOutputCache();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
