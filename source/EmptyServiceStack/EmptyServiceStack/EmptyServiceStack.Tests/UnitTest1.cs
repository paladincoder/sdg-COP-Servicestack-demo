using System;
using NUnit.Framework;
using PaladinGolf.ServiceInterface;
using PaladinGolf.ServiceModel;
using ServiceStack.Testing;
using ServiceStack;

namespace PaladinGolf.Tests
{
	[TestFixture]
	public class UnitTests
	{
		private readonly ServiceStackHost appHost;

		public UnitTests()
		{
			appHost = new BasicAppHost(typeof(GolfService).Assembly)
			{
				ConfigureContainer = container =>
				{
					//Add your IoC dependencies here
				}
			}
			.Init();
		}

		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			appHost.Dispose();
		}

		[Test]
		public void TestMethod1()
		{
			var service = appHost.Container.Resolve<GolfService>();

			var response = (PlayerResponse)service.Get(new PlayerRequest
			{
				LastName = "World"
			});

			//Assert.That(response.Result, Is.EqualTo("PlayerRequest, World!"));
		}
	}
}
