using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace PaladinGolf.ServiceModel
{
	[Route("/Results/{EventId}", Verbs = "GET")]
	public class ResultsRequest : IReturn<ResultsResponse>
	{
		[ApiMember(Description="The Id of the Event",IsRequired= true,DataType="Int.32")]
		public int EventId
		{
			get;
			set;
		}
	}
}
