//access tools to create and configure a web application host
using Microsoft.AspNetCore.Builder; 
// access tools to create services within our app that get added to our web application via dependency injection
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
  class Program
  {
    static void Main(string[] args) // Main() is our entry point
    {
      // begins process of building host
      // host contains all the application's resources and configrations need to run as a web app in a browser
      // builder is an object we use to configure how we want our web application host to be built
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
      // configures the host to enable MVC framework through AddControllersWithViews()
      builder.Services.AddControllersWithViews();
      // builder.Build() creates and returns our web app host
      WebApplication app = builder.Build();
      // specifies that we want our host to match the website URL to routes that we create within our apps
      // example: URL is localhost5000/Home/Index. host will know to match Home/Index to a route we coded in our project
      app.UseRouting();
      // establishes a convention for our routes to follow
      // this convention is default pattern we want our routes to follow
      // 1. list the name of controllers 2. name the action 3. get an id of the current object
      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );
      app.Run();
      // methods called on app are called middleware. middleware receives and handles requests from a user to access our website
    }
  }
}