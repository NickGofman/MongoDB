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
        public int musicianCount { get; set; }

        public string eventMusicianID { get; set; }



        public EventDetails(DateTime eventDate, string eventName, string eventStyle,string eventMusicianID, int musicianCount) {
            this.eventDate = eventDate;
            this.eventName = eventName;
            this.eventStyle = eventStyle;
            this.musicianCount = musicianCount;


            this.eventMusicianID = eventMusicianID;


        }
    }
}
