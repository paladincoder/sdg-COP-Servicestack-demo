using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.DataAnnotations;

namespace PaladinGolf.ServiceModel.Types
{
	public class Player
	{
		[AutoIncrement]
		[PrimaryKey]
		public int Id
		{
			get;
			set;
		}
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