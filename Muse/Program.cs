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
                Period = 2,
                Affluence = 7,
                InPosition = 0,
                Name = "A"
            };

            var leaf2 = new Leaf
            {
                Period = 3,
                Affluence = 7,
                InPosition = 0,
                Name = "B"
            };

            var song = new Song
            {
                Algorithm = Algorithm.D,
                BaseNote = 30,
                Duration = 400,
                Tracks = new Leaf[] { leaf, leaf2 }
            };
            
            seq.AlgoD(song);

            seq.Save("test5.mid");
        }
    }
}
