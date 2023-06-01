using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Models
{
    public class EventDetails
    {
        public DateTime eventDate { get; set; }
        public string eventName { get; set; }
        public string eventStyle { get; set; }
        public  string musicianName { get; set; }
        public string musicianInstrument { get; set; }

        public EventDetails(DateTime eventDate, string eventName, string eventStyle, string musicianName, string musicianInstrument) {
            this.eventDate = eventDate;
            this.eventName = eventName;
            this.eventStyle = eventStyle;
            this.musicianName = musicianName;
            this.musicianInstrument = musicianInstrument;


        }
    }
}
