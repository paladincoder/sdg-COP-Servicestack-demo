using System;
using EmptyServiceStack.ServiceInterface;
using EmptyServiceStack.ServiceModel;
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
			appHost = new BasicAppHost(typeof(MyServices).Assembly)
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
			var service = appHost.Container.Resolve<MyServices>();

			var response = (HelloResponse)service.Get(new Hello
			{
				Name = "World"
			});

			Assert.AreEqual<string>(response.Result, "Hello, World!");
		}

	}
}
