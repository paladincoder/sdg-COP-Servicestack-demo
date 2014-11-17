using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace PaladinGolf.ServiceModel.Types
{
	public class Event
	{
		[AutoIncrement]
		public int Id
		{
			get;
			set;
		}
		public DateTime Date
		{
			get;
			set;
		}
	}
}
