using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace PaladinGolf.ServiceModel.Types
{
	[Alias("GameEvent")]
	public class DbGameEvent
	{
		[AutoIncrement]
		public int Id
		{
			get;
			set;
		}
		[References(typeof(DbGame))]
		public int GameId
		{
			get;
			set;
		}
		[References(typeof(DbEvent))]
		public int EventId
		{
			get;
			set;
		}
	}
}
