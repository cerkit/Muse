using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMuse
{
    public partial class TrackEditor : UserControl
    {
        public TrackEditor()
        {
            InitializeComponent();
            _tracks = Array.Empty<Track>();
        }

        private Track[] _tracks;
        public Track[] Tracks
        {
            get
            {
                return _tracks;
            }
            set
            {
                _tracks = value;
                PopulateData();
            }
        }

        private void PopulateData()
        {
            trackListBox.Items.Clear();
            txtName.Text = string.Empty;
            txtInPosition.Text = string.Empty;
            txtChord.Text = string.Empty;
            txtOctave.Text = string.Empty;
            txtPeriod.Text = string.Empty;
            txtOffset.Text = string.Empty;

            foreach (var track in _tracks)
            {
                trackListBox.Items.Add(track);
            }
        }

        private void trackListBox_Click(object sender, EventArgs e)
        {
            if (trackListBox.SelectedItem != null)
            {
                var item = trackListBox.SelectedItem as Track;
                txtName.Text = item.Name;
                txtOctave.Text = item.Octave.ToString();
                txtOffset.Text = item.Offset.ToString();
                txtInPosition.Text = item.InPosition.ToString();
                txtChord.Text = item.OutPosition.ToString();
                txtPeriod.Text = item.Period.ToString();
                if (item.Chord != null)
                {
                    txtChord.Text = string.Join(',', item.Chord);
                }
            }
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            var trackList = _tracks.ToList();
            var track = new Track();
            track.Name = "New Track";
            trackList.Add(track);
            _tracks = trackList.ToArray();
            PopulateData();

        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            if (_tracks.Any())
            {
                var trackList = _tracks.ToList();
                trackList.Remove(_tracks[trackListBox.SelectedIndex]);
                _tracks = trackList.ToArray();
                PopulateData();
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any())
            {
                _tracks[trackListBox.SelectedIndex].Name = txtName.Text;
            }
        }

        private void txtOctave_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any())
            {
                if (int.TryParse(txtOctave.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].Octave = res;
                }
            }
        }

        private void txtOffset_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any())
            {
                if (int.TryParse(txtOffset.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].Offset = res;
                }
            }
        }

        private void txtPeriod_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any())
            {
                if (int.TryParse(txtPeriod.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].Period = res;
                }
            }
        }

        private void txtChord_KeyUp(object sender, KeyEventArgs e)
        {
            var noteList = new List<int?>();
            var l = txtChord.Text.Split(',');
            if (l.Any())
            {
                foreach(var n in l)
                {
                    if (int.TryParse(n, out int res))
                    {
                        noteList.Add(res);
                    }
                }

                _tracks[trackListBox.SelectedIndex].Chord = noteList.ToArray();
            }
            else
            {
                _tracks[trackListBox.SelectedIndex].Chord = Array.Empty<int?>();
            }
        }

        private void txtInPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any())
            {
                if (int.TryParse(txtInPosition.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].InPosition = res;
                }
            }
        }

        private void txtOutPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any())
            {
                if (int.TryParse(txtOutPosition.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].OutPosition = res;
                }
            }
        }
    }
}
