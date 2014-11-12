using System;
using ServiceStack.MiniProfiler;
using ServiceStack.MiniProfiler.Data;

namespace PaladinGolf
{
	public class Global : System.Web.HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			new AppHost().Init();
		}
		//protected void Application_BeginRequest(object src, EventArgs e)
		//{
		//	if (Request.IsLocal)
		//		Profiler.Start();
		
		//}

		//protected void Application_EndRequest(object src, EventArgs e)
		//{
		//	Profiler.Stop();
		//}

	}
}