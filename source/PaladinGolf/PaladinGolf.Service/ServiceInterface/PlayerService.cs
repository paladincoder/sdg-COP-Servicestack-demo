using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using PaladinGolf.ServiceModel;
using ServiceStack.Data;
using ServiceStack.Text;
using ServiceStack.OrmLite;
using System.Text;
using PaladinGolf.ServiceModel.Types;


namespace PaladinGolf.ServiceInterface
{

	public class PlayerService : Service
	{
		public PlayerResponse Delete(PlayerRequest request)
		{
			return null;
		}
		public PlayerResponse Get(PlayerRequest request)
		{
			List<DbPlayer> players = null;
			if (request.Id.HasValue)
				return new PlayerResponse()
				{
					Players = Db.Select<DbPlayer>(p => p.Id == request.Id)
				};
			else
			{

				if (request.LastName == null)
					request.LastName = string.Empty;

				players = Db.Select<DbPlayer>(p => p.LastName.StartsWith(request.LastName));

				if (!string.IsNullOrEmpty(request.FirstName))
				{
					players = players.TakeWhile(p => p.FirstName.StartsWithIgnoreCase(request.FirstName)).ToList();
				}


			}

			return new PlayerResponse()
					{
						Players = players
					};

		}

		public PlayerResponse Post(PlayerRequest request)
		{
			var p = request.ConvertTo<DbPlayer>();
			var id = Db.Save<DbPlayer>(p);
			return new PlayerResponse()
			{
				Players = new List<DbPlayer>(){p}
			};
		}
	}
}