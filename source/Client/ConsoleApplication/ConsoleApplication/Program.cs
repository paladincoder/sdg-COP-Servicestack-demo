using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationSS;
using PaladinGolfWebAPI.Models;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{


			

			Console.WriteLine("Generating 10 random names");
			var list = RandomBuilder().Result;
			Console.WriteLine("posting to WebApi");
			Stopwatch sw = new Stopwatch();
			sw.Start();
			PostPlayser(list);
			sw.Stop();
			Console.WriteLine(string.Format("took {0} miliseconds", sw.ElapsedMilliseconds));

			RunAsync().Wait();

			Console.ReadLine();

		}
		static async Task RunAsync()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://localhost:44811");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				// New code:
				HttpResponseMessage response = await client.GetAsync("api/players/");
				if (response.IsSuccessStatusCode)
				{
					var result = await response.Content.ReadAsAsync<List<Player>>();
					foreach (var p in result)
					Console.WriteLine("{0}\t{1}\t{2}", p.FirstName, p.LastName, p.HandicapIndex);
				}
			}
		}

		private async static Task<List<User>> RandomBuilder()
		{
			List<User> list = new List<User>();
			for (int i = 1; i < 10; i++)
			{

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("http://api.randomuser.me");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					HttpResponseMessage response = await client.GetAsync("");
					if (response.IsSuccessStatusCode)
					{
						var result = await response.Content.ReadAsAsync<PersonResult>();
						list.Add(result.results[0].user);
					}
				}
			}
			return list;
		}
		private static void PostPlayser(List<User> list)
		{
			Random ran = new Random(3);
			foreach (var p in list)
			{

				var num = ran.NextDouble() * 30;
				num = System.Math.Truncate(num * 10) / 10;
				var player = new Player()
				{
					FirstName = p.name.first,
					LastName = p.name.last,
					HandicapIndex = num
				};

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("http://localhost:44811");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					//wrong Route!
					var task = client.PostAsJsonAsync("api/Players", player).Result;
					
				}
			}
		}
	}
}





