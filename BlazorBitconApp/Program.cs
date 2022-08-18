/*using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBitcoinApp
{
	public class Program
	{

		public static void Main(string[] args)
		{
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

*/
using BlazorBitcoinApp.Services;
using BlazorBitcoinApp;
using Microsoft.AspNetCore.Components.Web;
using Amazon.OpsWorks.Model;
//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IBitcoinService, BitcoinService>();

await builder.Build().RunAsync();

//Erro de dependia do dotnet 5 para o dotnet 6 19:10 https://www.youtube.com/watch?v=fghFOg18LM4

