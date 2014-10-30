using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace PaladinGolf.ServiceModel
{
	[Route("/Events",Verbs="POST")]
	public class AttendeeRequest : IReturn <AttendeeResponse>
	{
		[ApiMember(Description="The Id of the Event")]
		public int Id
		{
			get;
			set;
		}
		[ApiMember(Description="The List of Player Ids")]
		public List<int> PlayerIds
		{
			get;
			set;
		}
		[ApiMember(Description="The list of game Ids in the event")]
		public List<int> EventIds
		{
			get;
			set;
		}

	}
}
