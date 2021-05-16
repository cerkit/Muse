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

        private void TrackListBox_Click(object sender, EventArgs e)
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

        private void BtnAddTrack_Click(object sender, EventArgs e)
        {
            var trackList = _tracks.ToList();
            var track = new Track();
            track.Name = "New Track";
            trackList.Add(track);
            _tracks = trackList.ToArray();
            PopulateData();

        }

        private void BtnRemoveTrack_Click(object sender, EventArgs e)
        {
            if (_tracks.Any())
            {
                var trackList = _tracks.ToList();
                trackList.Remove(_tracks[trackListBox.SelectedIndex]);
                _tracks = trackList.ToArray();
                PopulateData();
            }
        }

        private void TxtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any() && trackListBox.SelectedIndex > -1)
            {
                _tracks[trackListBox.SelectedIndex].Name = txtName.Text;
                trackListBox.Items[trackListBox.SelectedIndex] = _tracks[trackListBox.SelectedIndex];
                trackListBox.Refresh();
            }
        }

        private void TxtOctave_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any() && trackListBox.SelectedIndex > -1)
            {
                if (int.TryParse(txtOctave.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].Octave = res;
                }
                else
                {
                    _tracks[trackListBox.SelectedIndex].Octave = null;
                }
            }
        }

        private void TxtOffset_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any() && trackListBox.SelectedIndex > -1)
            {
                if (int.TryParse(txtOffset.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].Offset = res;
                }
                else
                {
                    _tracks[trackListBox.SelectedIndex].Offset = null;
                }
            }
        }

        private void TxtPeriod_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any() && trackListBox.SelectedIndex > -1)
            {
                if (int.TryParse(txtPeriod.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].Period = res;
                }
            }
        }

        private void TxtChord_KeyUp(object sender, KeyEventArgs e)
        {
            var noteList = new List<int?>();
            var l = txtChord.Text.Split(',');
            if (l.Any() && trackListBox.SelectedIndex > -1)
            {
                foreach(var n in l)
                {
                    if (int.TryParse(n.Trim(), out int res))
                    {
                        noteList.Add(res);
                    }
                }

                _tracks[trackListBox.SelectedIndex].Chord = noteList.ToArray();
            }
            else
            {
                _tracks[trackListBox.SelectedIndex].Chord = null;
            }
        }

        private void TxtInPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any() && trackListBox.SelectedIndex > -1)
            {
                if (int.TryParse(txtInPosition.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].InPosition = res;
                }
                else
                {
                    _tracks[trackListBox.SelectedIndex].InPosition = null;
                }
            }
        }

        private void TxtOutPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (_tracks.Any() && trackListBox.SelectedIndex > -1)
            {
                if (int.TryParse(txtOutPosition.Text, out int res))
                {
                    _tracks[trackListBox.SelectedIndex].OutPosition = res;
                }
                else
                {
                    _tracks[trackListBox.SelectedIndex].OutPosition = null;
                }
            }
        }
    }
}
