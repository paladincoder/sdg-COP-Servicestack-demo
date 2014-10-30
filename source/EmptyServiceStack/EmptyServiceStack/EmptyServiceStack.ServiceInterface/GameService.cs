using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaladinGolf.ServiceModel;
using PaladinGolf.ServiceModel.Types;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.Text;

namespace EmptyServiceStack.ServiceInterface
{
	public class GameService : Service
	{
		public GameResponse Get(GameRequest req)
		{
			if (req.Id > 0)
				return Db.SingleById<DbGame>(req.Id).ConvertTo<GameResponse>();
			throw new ArgumentException("Id is required");
		}

	}
}
