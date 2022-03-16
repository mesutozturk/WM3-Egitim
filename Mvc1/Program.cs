//Configure services
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllersWithViews();
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();

//Configure - Middleware
app.UseHttpsRedirection();
app.UseStaticFiles(); //wwwroot içindeki statik (html-css-js-img-video-audio)
//app.UseCookiePolicy();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
//app.UseSession();
//app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();