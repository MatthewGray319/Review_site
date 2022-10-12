
using Review_Project;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Review_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Review_ProjectContext") ?? throw new InvalidOperationException("Connection string 'Review_ProjectContext' not found.")));

// Add services to the container.
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ReviewContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
