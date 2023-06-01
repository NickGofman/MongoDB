using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Models
{
    [Serializable]  // this to export the file to the web

    public class Musician
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string MusicianID { get; set; }

        [BsonElement("musician_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Name { get; set; }

        [BsonElement("musician_age"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Age { get; set; }

        [BsonElement("instrument"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Instrument { get; set; }
        public Musician(string name,string age,string instrument)
        {
            Age = age;
            Name = name;
            Instrument = instrument;
        }
        public override string ToString()
        {
            return "Musician Name: " + Name + " Age: " + Age + " Instrument:" + Instrument; 
        }
    }
}
