namespace Muse
{
    public class Song
    {
        public int? BaseNote { get; set; }
        public string Name { get; set; }
        public float Duration { get; set; }
        public Leaf[] Tracks { get; set; }
        public int[] Seed { get; set; }
        public Algorithm Algorithm { get; set; }
    }
}
