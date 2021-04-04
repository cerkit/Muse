using Sanford.Multimedia.Midi;
using System;

namespace Muse
{
    public static class Extensions
    {
        public static int GetNote(this int[] scale, Song song, Leaf leaf)
        {
            var r = new Random();
            var ndx = r.Next(0, scale.Length - 1);
            var noteIndex = scale[ndx] + (leaf.Offset ?? 0);
            // calculate baseNote from song base note + the tracks octave
            var baseNote = Math.Min((song.BaseNote ?? 0) + (((leaf.Octave ?? 1) + 1) * 12), 127);
            return baseNote + noteIndex;
        }

        public static void InsertNote(this Track t, int pitch, int velocity, int position, int duration, int channel)
        {
            int NOTE_LENGTH = 6;
            ChannelMessageBuilder builder = new ChannelMessageBuilder();
            builder.Command = ChannelCommand.NoteOn;
            builder.Data1 = pitch;
            builder.Data2 = velocity;
            builder.MidiChannel = channel;
            builder.Build();
            t.Insert(position * NOTE_LENGTH, builder.Result);
            builder.Command = ChannelCommand.NoteOff;
            builder.Build();
            t.Insert((position + duration) * NOTE_LENGTH, builder.Result);
        }

        public static void AlgoD(this Sequence seq, Song song)
        {
            var channel = 0;
            foreach (var trk in song.Tracks)
            {
                var t = new Track();
                var noteDuration = trk.Period;

                // Loop from 0 to the s ong duration by 10 (an arbitrary song division)
                for (var pos = 0; pos <= song.Duration; pos += trk.Period)
                {

                    // Only process the note if we're within the range of the track's in
                    // and out position
                    var inPosition = trk.InPosition ?? 0;
                    var outPosition = trk.OutPosition ?? -1;
                    if (pos >= inPosition && (outPosition < 0 || pos < outPosition))
                    {
                        int note;
                        if (trk.Chord != null)
                        {
                            var chord = trk.Chord;
                            if (chord.Length > 0)
                            {
                                var r = new Random();
                                if (r.Next(0, 100) % 2 == 0)
                                {
                                    foreach (var noteIndex in chord)
                                    {
                                        // 33% chance that we'll render this note
                                        r = new Random();
                                        if (r.Next(0, 100) % 3 == 0)
                                        {
                                            note = Scales.JazzScale[Math.Min(noteIndex.Value, Scales.JazzScale.Length - 1)];
                                            //getJazzNote(song: song, track: trk) //song.baseNote + song.seed[noteIndex]
                                            // add the note
                                            t.InsertNote(note, 100, pos, noteDuration, channel);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            var r = new Random();
                            var newDuration = r.Next(1, 4);
                            for (var newPos = 0; newPos < newDuration; newPos++)
                            {
                                note = Scales.JazzScale.GetNote(song, trk);
                                t.InsertNote(note, 100, newPos + newDuration, newDuration, channel);
                            }
                        }
                    }
                }
                // switch to the next channel
                channel += 1;
                if (channel == 10)
                {
                    channel = 11;
                }

                seq.Add(t);
            }
        }
    }
}
