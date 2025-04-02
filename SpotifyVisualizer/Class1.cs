using System.IO;
using System.Text.Json;



namespace SpotifyVisualizer
{
    public class Class1
    {
        public static string GetData()
        {
           string data = File.ReadAllText("E:/Dukuemnte/SpotifyApp/SpotifyVisualizer/SpotifyVisualizer/Data/Streaming_History_Audio_2020-2021_6.json");
            List<JsonEntry> entries = JsonSerializer.Deserialize<List<JsonEntry>>(data).Where(entry => entry.Validate()).ToList();
            
            List<Track> tracks = entries.Select(entry => new Track(entry)).GroupBy(x => x.TrackUri).Select(x => x.First()).ToList();
            List<SpotifyStream> streams = entries.Select(entry => new SpotifyStream(entry)).ToList();
            
            return $"The Data contains {streams.Count()} streams with {tracks.Count()} unique Songs";
            
        }

    }
}