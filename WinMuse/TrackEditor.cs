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
            txtOutPosition.Text = string.Empty;
            txtOctave.Text = string.Empty;
            txtPeriod.Text = string.Empty;
            txtOffset.Text = string.Empty;

            foreach(var track in _tracks)
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
                txtOutPosition.Text = item.OutPosition.ToString();
                txtPeriod.Text = item.Period.ToString();
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
            var trackList = _tracks.ToList();
            trackList.Remove(_tracks[trackListBox.SelectedIndex]);
            _tracks = trackList.ToArray();
            PopulateData();
        }
    }
}
