using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Models
{
    class AssignedMusicianView
    {
        public string MusicianID { get; set; }
        public string MusicianName { get; set; }
        public string Instrument { get; set; }

        public override string ToString()
        {
            // Return a formatted string representation for display in the ListBox
            return $"{MusicianName} - {Instrument}";
        }
    }
}
