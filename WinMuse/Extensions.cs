using MIDI = Sanford.Multimedia.Midi;
using System;

namespace WinMuse
{
    public static class Extensions
    {
        public static int GetNote(this int[] scale, Song song, Track track)
        {
            var r = new Random();
            var ndx = r.Next(0, scale.Length - 1);
            var noteIndex = scale[ndx] + (track.Offset ?? 0);
            // calculate baseNote from song base note + the tracks octave
            var baseNote = Math.Min((song.BaseNote ?? 0) + (((track.Octave ?? 1) + 1) * 12), 127);
            return baseNote + noteIndex;
        }

        public static void InsertNote(this Sanford.Multimedia.Midi.Track t, int pitch, int velocity, int position, int duration, int channel)
        {
            MIDI.ChannelMessageBuilder builder = new()
            {
                Command = MIDI.ChannelCommand.NoteOn,
                Data1 = pitch,
                Data2 = velocity,
                MidiChannel = channel
            };
            builder.Build();
            t.Insert(position, builder.Result);
            builder.Command = MIDI.ChannelCommand.NoteOff;
            builder.Build();
            t.Insert(position + duration, builder.Result);
        }

        public static Sanford.Multimedia.Midi.Track AddNotes(this Track track, Song song, int channel, int startPosition, int[] scale)
        {
            var trk = new Sanford.Multimedia.Midi.Track();
            var r = new Random();
            var noteFrequency = r.Next(track.Period / 3, track.Period);
            var noteDuration = track.Period + noteFrequency;
            for (var i = startPosition; i <= (startPosition + noteFrequency); i += noteFrequency)
            {
                var note = scale.GetNote(song, track);
                // add the note
                trk.InsertNote(note, 127, i, noteDuration, channel);
            }

            return trk;
        }

        public static void AlgoA(this MIDI.Sequence seq, Song song)
        {
            var channel = 0;
            foreach (var trk in song.Tracks)
            {
                var t = new MIDI.Track();
                var noteDuration = trk.Period;

                // Loop from 0 to the s ong duration by 10 (an arbitrary song division)
                for (var pos = 0; pos <= song.Duration + 16; pos+=16)
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
                            note = Scales.JazzScale.GetNote(song, trk);
                            var r = new Random();
                            // 50% chance we'll play the note
                            if (r.Next(1, 100) % 2 == 0)
                            {
                                t.InsertNote(note, 100, pos, noteDuration, channel);
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
        public static void AlgoB(this MIDI.Sequence seq, Song song)
        {
            var channel = 0;
            foreach (var trk in song.Tracks)
            {
                var t = new MIDI.Track();
                var noteDuration = trk.Period;

                // Loop from 0 to the song duration by 36
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
                                if (r.Next(0, 99) % 3 > 0)
                                {
                                    foreach (var noteIndex in chord)
                                    {
                                        // high chance that we'll render this note
                                        r = new Random();
                                        if (r.Next(0, 99) % 3 > 0)
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
                            note = Scales.JazzScale.GetNote(song, trk);
                            var r = new Random();
                            // high chance we'll play the note
                            if (r.Next(0, 100) % 3 > 0)
                            {
                                t.InsertNote(note, 100, pos, noteDuration, channel);
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
        public static void AlgoC(this MIDI.Sequence seq, Song song)
        {
            var channel = 0;
            foreach (var trk in song.Tracks)
            {
                var t = new MIDI.Track();
                var noteDuration = trk.Period;

                // Loop from 0 to the song duration by 36
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
                                if (r.Next(0, 99) % 3 > 0)
                                {
                                    foreach (var noteIndex in chord)
                                    {
                                        // high chance that we'll render this note
                                        r = new Random();
                                        if (r.Next(0, 99) % 3 > 0)
                                        {
                                            var baseNote = Math.Min((song.BaseNote ?? 0) + (((trk.Octave ?? 1) + 1) * 12), 127);
                                            note = baseNote + Scales.JazzScale[Math.Min(noteIndex.Value, Scales.JazzScale.Length - 1)];
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
                            note = Scales.JazzScale.GetNote(song, trk);
                            var r = new Random();
                            // high chance we'll play the note
                            if (r.Next(0, 100) % 3 > 0)
                            {
                                t.InsertNote(note, 100, pos, noteDuration, channel);
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
