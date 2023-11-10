using ENTJAVA_Week3.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Add NewsService
        services.AddTransient<NewsService>(provider => new NewsService("66fcbe38577c46619b0adfef660f24d4"));

        // Add other services as needed
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        // Configure your routes here
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "NewsServiceController",
                pattern: "NewsServiceController/{action=Index}/{id?}",
                defaults: new { controller = "NewsServiceController" });

            // Add default route
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
