using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace PaladinGolf.ServiceModel
{
	public class GameRequest : IReturn<GameResponse>
	{
		public List<int> GameIds
		{
			get;
			set;
		}
		public List<int> PlayerIds
		{
			get;
			set;
		}

		public int Id
		{
			get;
			set;
		}
	}
}
