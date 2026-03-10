using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using MyStaticSite.Pipelines; 
// importing the ProjectsPipeline class from the MyStaticSite.Pipelines 
// namespace. This allows us to use the ProjectsPipeline in our application.

namespace MyStaticSite
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .AddPipeline<ProjectsPipeline>()
                // adding the ProjectsPipeline to the application. This means 
                // that the ProjectsPipeline will be executed as part of the application's processing pipeline.
                .RunAsync();
    }
    // The above code is the entry point for a Statiq web application.
    // It uses the Bootstrapper class to create and run the web application asynchronously.
    // The Main method is the starting point of the application 
    // and it returns an integer status code when the application finishes running.
}