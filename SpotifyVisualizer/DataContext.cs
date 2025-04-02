using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpotifyVisualizer
{
    internal class DataContext
    {
        private List<Track> tracks;
        private List<SpotifyStream> streams;

        public DataContext()
        {
            tracks = new List<Track>();
            streams = new List<SpotifyStream>();
        }

        public void AddFromFile (string path)
        {
            string data = File.ReadAllText(path);
            List<JsonEntry> entries = JsonSerializer.Deserialize<List<JsonEntry>>(data).Where(entry => entry.Validate()).ToList();



            tracks = tracks.Concat(entries.Select(entry => new Track(entry))).GroupBy(x => x.TrackUri).Select(x => x.First()).ToList();
            streams.AddRange(entries.Select(entry => new SpotifyStream(entry)));
        }
        public string InfoString()
        {
            return $"The Data contains {streams.Count()} streams and {tracks.Count()} unique Tracks";
        }
    }
    


}
