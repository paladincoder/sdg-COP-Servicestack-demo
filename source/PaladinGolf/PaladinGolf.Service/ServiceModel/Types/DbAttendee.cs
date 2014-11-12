using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace PaladinGolf.ServiceModel.Types
{
	[Alias("Attendee")]
	public class DbAttendee
	{
		[AutoIncrement]
		public int Id
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
		[References(typeof(DbPlayer))]
		public int PlayerId
		{
			get;
			set;
		}
	}
}
