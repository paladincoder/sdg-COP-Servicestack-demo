using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using PaladinGolf.ServiceModel;
using PaladinGolf.Data.Types;
using ServiceStack.Data;
using ServiceStack.Text;
using ServiceStack.OrmLite;
using System.Text;


namespace PaladinGolf.ServiceInterface
{

	public class PlayerService : Service
	{

		public PlayerResponse Get(PlayerRequest request)
		{
			if (request.Id.HasValue)
				return new PlayerResponse()
				{
					Players = Db.Select<DbPlayer>(p => p.Id == request.Id)
				};
			else
			{
				List<DbPlayer> players = null;
				if (!string.IsNullOrEmpty(request.LastName))
				{
					players = Db.Select<DbPlayer>(p => p.LastName.StartsWith(request.LastName));

					if (!string.IsNullOrEmpty(request.FirstName))
					{
						players = players.TakeWhile(p => p.FirstName.StartsWithIgnoreCase(request.FirstName)).ToList();
					}
					return new PlayerResponse()
					{
						Players = players
					};

				}
			}
			//By default, ArgumentException will return a 400 error to client
			throw new ArgumentException("Bad Request");
		}

		public PlayerResponse Post(PlayerRequest request)
		{
			var p = request.ConvertTo<DbPlayer>();
			var id = Db.Save<DbPlayer>(p);
			return new PlayerResponse()
			{
				Players = new List<DbPlayer>() { p }
			};
		}
	}
}