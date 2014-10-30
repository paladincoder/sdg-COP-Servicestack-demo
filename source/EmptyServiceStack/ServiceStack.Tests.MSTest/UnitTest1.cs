using System;
using PaladinGolf.ServiceInterface;
using PaladinGolf.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack.Testing;

namespace ServiceStack.Tests.MSTest
{
	[TestClass]
	public class UnitTest1
	{
		private static ServiceStackHost appHost;
		[ClassInitialize]
		public static void TestInitialize(TestContext context)
		{
			appHost = new BasicAppHost(typeof(GolfService).Assembly)
			{
				ConfigureContainer = container =>
				{
					//Add your IoC dependencies here
				}
			}.Init();
		}
		[ClassCleanup]
		public static void TestCleanup()
		{
			appHost.Dispose();
		}

		[TestMethod]
		public void TestMethod1()
		{
			var service = appHost.Container.Resolve<GolfService>();
			var client = new JsonServiceClient("http://golf");


			var req =new PlayerRequest
			{
				LastName = "Thompson"
			};
			client.Post(req);
			
		}

	}
}
