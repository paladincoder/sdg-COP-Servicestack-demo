using Funq;
using ServiceStack;
using PaladinGolf.ServiceInterface;
using System.Data;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using PaladinGolf.Data;
using System.Configuration;
using ServiceStack.MiniProfiler;
using ServiceStack.MiniProfiler.Data;

namespace PaladinGolf
{
	public class AppHost : AppHostBase
	{
		/// <summary>
		/// Default constructor.
		/// Base constructor requires a name and assembly to locate web service classes. 
		/// </summary>
		public AppHost()
			: base("PaladinGolf", typeof(PlayerService).Assembly)
		{

		}

		/// <summary>
		/// Application specific configuration
		/// This method should initialize any IoC resources utilized by your web service classes.
		/// </summary>
		/// <param name="container"></param>
		public override void Configure(Container container)
		{
			SetConfig(new HostConfig
			{
				HandlerFactoryPath = "api"
			});

			string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
			container.Register<IDbConnectionFactory>(c => new PaladinGolfDataConnectionFactory(connectionString)
			{
				ConnectionFilter = x => new ProfiledDbConnection(x, Profiler.Current)
			});
		}
	}
}