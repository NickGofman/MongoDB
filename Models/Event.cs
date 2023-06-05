using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Models
{
    [Serializable]  // this to export the file to the web
    public class Event
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string EventID { get; set; }

        [BsonElement("event_date"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime Date { get; set; }

        [BsonElement("event_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string EventName { get; set; }

        [BsonElement("musical_style"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string MusicalStyle { get; set; }

        public Event( DateTime date, string eventName, string musicalStyle)
        {
            Date = date;
            EventName = eventName;
            MusicalStyle = musicalStyle;

        }
        public override string ToString()
        {
            string date = Date.ToString("dd/MM/yyyy");

            return "Event Name: " + EventName + " Date: " + date + " Musical Style:" + MusicalStyle;
        }
    }
}
