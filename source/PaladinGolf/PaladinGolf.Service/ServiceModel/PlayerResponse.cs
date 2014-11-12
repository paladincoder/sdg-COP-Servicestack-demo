using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaladinGolf.ServiceModel.Types;
using ServiceStack;

namespace PaladinGolf.ServiceModel
{

	public class PlayerResponse : IHasResponseStatus
	{
		public ResponseStatus ResponseStatus
		{
			get;
			set;
		}

		public List<DbPlayer> Players
		{
			get;
			set;
		}
	}
}
