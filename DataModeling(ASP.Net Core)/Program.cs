using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModeling_ASP.Net_Core_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (DatasContext db = new DatasContext())
            {
                var items = db.MainDates.ToList();
                //item = items[0].ToString();
                Console.WriteLine("Items:");
                foreach (MainDate md in items)
                {
                    Console.WriteLine($"{md.Id} -- {md.Country} -- {md.Itemdate}");
                }
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
