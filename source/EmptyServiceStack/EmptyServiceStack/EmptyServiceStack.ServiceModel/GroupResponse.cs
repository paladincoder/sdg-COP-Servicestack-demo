using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;

namespace PaladinGolf.ServiceModel
{
	public class AttendeeResponse : IHasResponseStatus
	{
		public ResponseStatus ResponseStatus
		{
			get;
			set;
		}
	}
}
