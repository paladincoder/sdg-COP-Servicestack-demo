using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaladinGolf.ServiceModel;
using ServiceStack;

namespace ConsoleApplicationSS
{
	class Program
	{
		static void Main(string[] args)
		{
			//generate a bunch of random data

			Console.WriteLine("Generating 10 random names");
			var list = RandomBuilder().Result;
			Console.WriteLine("posting to servicestack");
			Stopwatch sw = new Stopwatch();
			sw.Start();
			PostPlayser(list);
			sw.Stop();
			Console.WriteLine(string.Format("took {0} miliseconds", sw.ElapsedMilliseconds));

			//prints names
			var response = RunAsync();
		
			Console.ReadLine();
		}

		private static async Task<List<User>> RandomBuilder()
		{
			List<User> list = new List<User>();
			for (int i = 1; i < 10; i++)
			{

				var client = new JsonServiceClient("http://api.randomuser.me");
				var result = await client.GetAsync<PersonResult>(string.Empty);

				list.Add(result.results[0].user);
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
				var player = new PlayerRequest()
				{
					FirstName = p.name.first,
					LastName = p.name.last,
					HandicapIndex = num
				};
				var client = new JsonServiceClient("http://localhost:23813");
				var response = client.PostAsync(player).Result;

			}
		}
		static async Task RunAsync()
		{
			var client = new JsonServiceClient("http://localhost:23813");
			var response = await client.GetAsync(new PlayerRequest()
			{

			});

			foreach (var p in response.Players)
				Console.WriteLine("{0}\t{1}\t{2}", p.FirstName, p.LastName, p.HandicapIndex);

		}
	}
}
