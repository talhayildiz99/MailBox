using MailBox.BusinessLayer.Abstract;
using MailBox.BusinessLayer.Concrete;
using MailBox.DataAccessLayer.Abstract;
using MailBox.DataAccessLayer.Context;
using MailBox.DataAccessLayer.EntityFramework;
using MailBox.EntityLayer.Concrete;
using MailBox.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MailContext>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<MailContext>().AddErrorDescriber<MailIdentityValidator>();
builder.Services.AddScoped<IMailService, MailManager>();
builder.Services.AddScoped<IMailDal, EfMailDal>();


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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
