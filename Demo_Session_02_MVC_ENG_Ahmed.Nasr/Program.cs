namespace Demo_Session_02_MVC_ENG_Ahmed.Nasr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            /////////////////////////Main الحاجه اللي لازم تتكتب في ال////////////////////////////////////////////

            // Add To Any Server U Need To The Container
            //         (((1.))
            builder.Services.AddControllersWithViews(); // Register The Built-in MVC Service in The Container -->MVC عشان البرنامج يشتغل 
         // builder.Services.AddControllers();          //  Register The Built-in APIs Service in The Container
         // builder.Services.AddRazorPages();           //  Register The Built-in AddRazorPages Service in The Container
         // builder.Services.AddMvc();                  //  Register The Built-in All Web Service in The Container -->(MVC and Razor Pages and APIs) <-- بتاعت services بتعمل ليا كل ال 


            var app = builder.Build();


            /////////////////     ((2.))
            app.UseStaticFiles();//Midlleware use it for Static File ==>ويشتغل cssبتاع ال bootstrap دي عشان تنادي علي ال 


            //app.MapGet("/", () => "Hello World!");
            // app.MapGet("/hamada", () => "Hello hamada!");
            // app.MapGet("/Singin", () => "Hello Singin!");

            // http://localhost:5001/Movies/GetMovie/1


            //MapGet دي بدل ما اعمل كل شويه
            ///////////    ((3.))
            app.MapControllerRoute(
                name: "Default",
                pattern: "/{Controller=Home}/{action=Index}/{id?}"
            //defaults:new {action = "Test"} // ده الشكل القديم


            //pattern: "/{Controller}/{action}/{id}"
            //pattern: "/{Controller}/{action}/{id?}"
            //pattern: "/{Controller =Movies}/{action=Test}/{id=1}"//(ده الشكل الجديد)Defaults اللي اسمها KeyWord كدا او استخدم ال Default Value ممكن اديله 
            //pattern:"/{Controller = Movies}/{action= Test}/{id?}"
            //pattern: "/{Controller = Movies}/{action= Test}/{id:int?}"
            //pattern: "/{Controller = Movies}/{action= Test}/{id:alpha?}"
            //pattern: "/Controller /action/id"

            ); //AddControllersWithViews لي ال call تشتغل لازم اعمل (MapControllerRoute) لازم عشان ال


            app.Run();
        }
        static string Singin()
        {
            return "Sigin";
        }
    }
}
