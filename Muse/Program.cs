using System;
using Sanford.Multimedia.Midi;

namespace Muse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diminished Jazz Scale
            var scale = new int[] { 3, 5, 6, 8, 9, 11, 12, 14, 15 };

            using var seq = new Sequence();

            var leaf = new Leaf
            {
                Period = 10,
                Affluence = 7,
                InPosition = 0,
                Name = "A"
            };

            var song = new Song
            {
                Algorithm = Algorithm.D,
                BaseNote = 50,
                Duration = 100,
                Tracks = new Leaf[] { leaf }
            };

            var track = leaf.AddNotes(song, 0, 0, scale);

            seq.Add(track);
            seq.Save("test.mid");
        }
    }
}
