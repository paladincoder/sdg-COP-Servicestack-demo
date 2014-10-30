using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.DataAnnotations;
using PaladinGolf.ServiceModel;

namespace PaladinGolf.ServiceModel
{
	[Route("/Players/{Id}",Verbs="GET,DELETE",Notes="Delete In release 3")]
	[Route("/Players/", Verbs = "GET,POST,PUT")]
	public class PlayerRequest : IReturn<PlayerResponse>
	{
		public int? Id
		{
			get;
			set;
		}
		[ApiMember(IsRequired = true)]
		[Required]
		public string FirstName
		{
			get;
			set;
		}
		public string LastName
		{
			get;
			set;
		}
		public int? GHIN
		{
			get;
			set;
		}
		public double? HandicapIndex
		{
			get;
			set;
		}
	}

}