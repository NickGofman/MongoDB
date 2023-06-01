using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Models
{
    [Serializable]  // this to export the file to the web
    public class EventMusician
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string EventMusicianID { get; set; }

        [BsonElement("musician_ID"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string MusicianID { get; set; }

        [ BsonElement("event_ID"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string EventID { get; set; }

        public EventMusician(string eventId, string musicianID)
        {
            EventID = eventId;
            MusicianID = musicianID;
         
        }
    }
}
