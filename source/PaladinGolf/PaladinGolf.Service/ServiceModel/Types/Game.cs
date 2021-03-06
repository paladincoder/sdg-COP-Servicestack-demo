﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace PaladinGolf.ServiceModel.Types
{
	public class Game
	{
		[AutoIncrement]
		public int Id
		{
			get;
			set;
		}
		[Alias("GameName")]
		public string Name
		{
			get;
			set;
		}
	}
}
