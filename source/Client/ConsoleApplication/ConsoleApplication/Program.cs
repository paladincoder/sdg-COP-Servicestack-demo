using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using PaladinGolfWebAPI.Models;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{


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
	}
}





