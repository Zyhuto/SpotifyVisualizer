using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpotifyVisualizer
{
    public class SpotifyStream
    {
        public string TrackUri { get; set; }
        public DateTime Timestamp { get; set; }
        public int Playtime { get; set; }

        internal SpotifyStream (JsonEntry entry)
        {
            TrackUri = entry.TrackUri;
            Timestamp = entry.Timestamp;
            Playtime = entry.Playtime;
        }

    }
}
