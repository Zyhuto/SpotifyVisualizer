using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpotifyVisualizer
{
    public class Track
    {
        
        public string TrackUri { get; set; }
        public string TrackName { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }

        internal Track (JsonEntry entry)
        {
            TrackUri = entry.TrackUri;
            TrackName = entry.TrackName;
            AlbumName = entry.AlbumName;
            ArtistName = entry.ArtistName;
        }
        
        

    }
}
