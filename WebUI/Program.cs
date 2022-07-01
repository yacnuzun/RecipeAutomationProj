using Business.Abstract;
using Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IUserService,UserManager>();
builder.Services.AddSingleton<ISpecificationService, SpecificationManager>();
builder.Services.AddSingleton<ICategoryService,CategoryManager>();
builder.Services.AddSingleton<IMaterialService, MaterialManager>();
builder.Services.AddSingleton<IRoleService, RoleManager>();
builder.Services.AddSingleton<ISpecificationMaterialService, SpecificationMaterialManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Repice}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "areas",
    pattern: "{area=exists}/{controller=Recipe}/{action=Index}/{id?}");

app.Run();
