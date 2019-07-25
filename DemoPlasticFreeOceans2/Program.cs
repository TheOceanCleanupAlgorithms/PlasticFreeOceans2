using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DemoPlasticFreeOceans2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string filename = "C:/Users/t-emclau/Desktop/image.jfif";
            //ImageToArray img = new ImageToArray();
            //Task<string> answer =  img.request_AIAsync(filename);
            //var key = answer.Result;
            //var butt = 4;

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
