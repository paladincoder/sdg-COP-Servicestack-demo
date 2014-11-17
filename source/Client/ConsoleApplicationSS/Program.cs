using System;
using System.Collections.Generic;
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

			var response = RunAsync();
						
			Console.ReadLine();
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
