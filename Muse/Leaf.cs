using Sanford.Multimedia.Midi;
using System;

namespace Muse
{
    public class Leaf
    {
        public string Name { get; set; }
        public int? Offset { get; set; }
        public int? Octave { get; set; }
        public int Period { get; set; }
        public float? InPosition { get; set; }
        public float? OutPosition { get; set; }
        public int Affluence { get; set; }
        public int?[] Chord { get; set; }

        public Track AddNotes(Song song, int channel, int startPosition, int[] scale)
        {
            var track = new Track();
            var r = new Random();
            var noteFrequency = r.Next(Period / 3, Period);
            var noteDuration = Period + noteFrequency;
            for (var i = startPosition; i <= (startPosition + noteFrequency); i += noteFrequency)
            {
                var note = scale.GetNote(song, this);
                // add the note
                track.InsertNote(note, 127, i, noteDuration, channel);
            }

            return track;
        }
    }
}
