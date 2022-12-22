using WebAppMVC1.interfaces;
using WebAppMVC1.mocks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();
builder.Services.AddMvc();
//builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IAllCars,MockCars>();
    services.AddTransient<ICarsCategory, MockCategory>();
    services.AddMvc();
    //services.AddMvc(option => option.EnableEndpointRouting = false);
}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
