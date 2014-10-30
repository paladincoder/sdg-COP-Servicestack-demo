using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaladinGolf.ServiceModel;
using ServiceStack;

namespace EmptyServiceStack.ServiceInterface
{
	public class ResultsService : Service
	{
		public ResultsResponse Get(ResultsRequest request)
		{
			return new ResultsResponse();
		}
	}
}
