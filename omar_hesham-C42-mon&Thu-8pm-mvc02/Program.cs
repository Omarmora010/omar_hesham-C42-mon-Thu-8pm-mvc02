namespace omar_hesham_C42_mon_Thu_8pm_mvc02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();


            app.UseRouting();


            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=Index}/{id:int?}"
                );

            app.MapControllerRoute(
                name: "AboutUs",
                pattern: "{controller=Home}/{action=AboutUs}"
                );


            app.MapControllerRoute(
                name: "AboutUs",
                pattern: "{controller=Home}/{action=AboutUs}"
                );

            app.Run();
        }
    }
}
