using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using EmptyServiceStack.ServiceModel;

namespace EmptyServiceStack.ServiceInterface
{
	public class MyServices : Service
	{
		public HelloResponse Get(Hello request)
		{
			return new HelloResponse
			{
				Result = "Hello, {0}!".Fmt(request.Name)
			};
		}
	}
}