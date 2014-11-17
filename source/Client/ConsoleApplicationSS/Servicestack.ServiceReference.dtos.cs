/* Options:
Date: 2014-11-16 23:26:25
Version: 1
BaseUrl: /api

//MakePartial: True
//MakeVirtual: True
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: True
//AddDefaultXmlNamespace: http://schemas.servicestack.net/types
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using PaladinGolf.ServiceModel.Types;
using PaladinGolf.ServiceModel;


namespace PaladinGolf.ServiceModel
{

    [Route("/Events", "POST")]
    public partial class AttendeeRequest
        : IReturn<AttendeeResponse>
    {
        public AttendeeRequest()
        {
            PlayerIds = new List<int>{};
            EventIds = new List<int>{};
        }

        [ApiMember(Description="The Id of the Event", DataType="string")]
        public virtual int Id { get; set; }

        [ApiMember(Description="The List of Player Ids", DataType="string")]
        public virtual List<int> PlayerIds { get; set; }

        [ApiMember(Description="The list of game Ids in the event", DataType="string")]
        public virtual List<int> EventIds { get; set; }
    }

    public partial class AttendeeResponse
    {
        public virtual ResponseStatus ResponseStatus { get; set; }
    }

    public partial class EventRequest
        : IReturn<EventResponse>
    {
        public EventRequest()
        {
            GameIds = new List<int>{};
            PlayerIds = new List<int>{};
        }

        public virtual List<int> GameIds { get; set; }
        public virtual List<int> PlayerIds { get; set; }
    }

    public partial class EventResponse
    {
        public virtual ResponseStatus ResponseStatus { get; set; }
    }

    [Route("/Games/{Id}")]
    public partial class GameRequest
        : IReturn<GameResponse>
    {
        public virtual int Id { get; set; }
    }

    public partial class GameResponse
    {
        public GameResponse()
        {
            Games = new List<Game>{};
        }

        public virtual ResponseStatus ResponseStatus { get; set; }
        public virtual List<Game> Games { get; set; }
    }

    [Route("/Players/", "GET,POST,PUT")]
    [Route("/Players/{Id}", "GET,DELETE")]
    public partial class PlayerRequest
        : IReturn<PlayerResponse>
    {
        public virtual int? Id { get; set; }
        [ApiMember(IsRequired=true, DataType="string")]
        [Required]
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }
        public virtual int? GHIN { get; set; }
        public virtual double? HandicapIndex { get; set; }
    }

    public partial class PlayerResponse
    {
        public PlayerResponse()
        {
            Players = new List<Player>{};
        }

        public virtual ResponseStatus ResponseStatus { get; set; }
        public virtual List<Player> Players { get; set; }
    }

    [Route("/Results/{EventId}", "GET")]
    public partial class ResultsRequest
        : IReturn<ResultsResponse>
    {
        [ApiMember(Description="The Id of the Event", IsRequired=true, DataType="Int.32")]
        public virtual int EventId { get; set; }
    }

    public partial class ResultsResponse
    {
        public virtual ResponseStatus ResponseStatus { get; set; }
    }
}

namespace PaladinGolf.ServiceModel.Types
{

    public partial class Game
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }

    public partial class Player
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int? GHIN { get; set; }
        public virtual double? HandicapIndex { get; set; }
    }
}

