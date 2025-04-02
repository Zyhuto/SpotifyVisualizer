using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpotifyVisualizer
{
    internal class JsonEntry
    {
        [JsonPropertyName("spotify_track_uri")]
        public string TrackUri { get; set; }

        [JsonPropertyName("ts")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("ms_played")]
        public int Playtime { get; set; }
        
        [JsonPropertyName("master_metadata_track_name")]
        public string TrackName { get; set; }

        [JsonPropertyName("master_metadata_album_artist_name")]
        public string ArtistName { get; set; }

        [JsonPropertyName("master_metadata_album_album_name")]
        public string AlbumName { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(TrackUri) &&
                   !string.IsNullOrWhiteSpace(TrackName) &&
                   !string.IsNullOrWhiteSpace(ArtistName) &&
                   !string.IsNullOrWhiteSpace(AlbumName) &&
                   Playtime > 0;
        }

    }
}
