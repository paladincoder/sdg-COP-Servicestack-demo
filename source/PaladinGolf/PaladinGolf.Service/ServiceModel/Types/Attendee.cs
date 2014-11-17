using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace PaladinGolf.ServiceModel.Types
{
	
	public class Attendee
	{
		[AutoIncrement]
		public int Id
		{
			get;
			set;
		}
		[References(typeof(Event))]
		public int EventId
		{
			get;
			set;
		}
		[References(typeof(Player))]
		public int PlayerId
		{
			get;
			set;
		}
	}
}
