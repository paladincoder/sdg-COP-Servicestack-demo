using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace PaladinGolf.ServiceModel
{
	[Route("/Games/{Id}")]
	public class GameRequest : IReturn<GameResponse>
	{

		public int Id
		{
			get;
			set;
		}
	}
}
