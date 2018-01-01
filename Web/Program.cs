using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace TheGodfatherGM.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://74.139.128.254:5000", "http://*:5000")
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();
                        
            host.Run();
        }
    }
}
