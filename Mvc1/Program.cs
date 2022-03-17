//Configure services

using Mvc1.Services.Email;
using SendGrid.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IMailService, YandexEmailService>();
builder.Services.AddSendGrid(options =>
{
    options.ApiKey = "Key";
});
builder.Services.AddControllersWithViews();
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();

var app = builder.Build();
//Configure - Middleware
app.UseHttpsRedirection();
app.UseStaticFiles(); //wwwroot içindeki statik (html-css-js-img-video-audio)
//app.UseCookiePolicy();
app.UseRouting();
// app.UseAuthentication();
// app.UseAuthorization();
//app.UseSession();
//app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();