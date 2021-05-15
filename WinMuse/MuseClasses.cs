using System.Text.Json.Serialization;

namespace WinMuse
{
    public class Song
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("baseNote")]
        public int? BaseNote { get; set; }
        [JsonPropertyName("duration")]
        public int Duration { get; set; }
        [JsonPropertyName("tracks")]
        public Track[] Tracks { get; set; }
        [JsonPropertyName("seed")]
        public int[] Seed { get; set; }
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }
    }

    public class Track
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("octave")]
        public int? Octave { get; set; }
        [JsonPropertyName("chord")]
        public int[] Chord { get; set; }
        [JsonPropertyName("offset")]
        public int? Offset { get; set; }
        [JsonPropertyName("period")]
        public int Period { get; set; }
        [JsonPropertyName("inPosition")]
        public int? InPosition { get; set; }
        [JsonPropertyName("outPosition")]
        public int? OutPosition { get; set; }
        [JsonPropertyName("affluence")]
        public int Affluence { get; set; }
    }

}
