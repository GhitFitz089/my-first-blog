using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;

namespace MyStaticSite
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .RunAsync();
    }
    // The above code is the entry point for a Statiq web application.
    // It uses the Bootstrapper class to create and run the web application asynchronously.
    // The Main method is the starting point of the application 
    // and it returns an integer status code when the application finishes running.
}