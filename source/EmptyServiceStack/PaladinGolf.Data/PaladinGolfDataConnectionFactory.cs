using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace PaladinGolf.Data
{
    public class PaladinGolfDataConnectionFactory : OrmLiteConnectionFactory
	{
		public PaladinGolfDataConnectionFactory(string connectionString) :base(connectionString, SqlServerDialect.Provider)
		{
		}
	}
}
