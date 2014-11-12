using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaladinGolf.ServiceModel;
using ServiceStack;

namespace EmptyServiceStack.ServiceInterface
{
	public class GroupService : Service
	{
		public AttendeeResponse Post(AttendeeRequest req)
		{

			return new AttendeeResponse();
		}
	}
}
