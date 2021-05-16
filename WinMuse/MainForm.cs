using Sanford.Multimedia.Midi;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinMuse
{
    public partial class MainForm : Form
    {
        private Song _song;
        private TrackEditor _trackEditor;

        public MainForm()
        {
            InitializeComponent();
            menuFileNew.Click += menuFileNew_Clicked;
            menuFileOpen.Click += menuFileOpen_ItemClicked;
            menuFileSave.Click += menuFileSave_ItemClicked;

            _trackEditor = new TrackEditor();
            pnlMain.Controls.Add(_trackEditor);
            _trackEditor.Dock = DockStyle.Fill;
            _trackEditor.Padding = new Padding(10);

            _song = new Song();
        }

        private void menuFileNew_Clicked(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtSongName.Text = string.Empty;
            txtBaseNote.Text = string.Empty;
            txtDuration.Text = string.Empty;
            _trackEditor.Tracks = Array.Empty<Track>();
        }

        private void menuFileSave_ItemClicked(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _song.Tracks = _trackEditor.Tracks;
                var songJson = JsonSerializer.Serialize(_song);
                using var songFile = File.CreateText(saveFileDialog1.FileName);
                songFile.Write(songJson);
            }
        }

        private void menuFileOpen_ItemClicked(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using var f = File.OpenText(openFileDialog1.FileName);
                var sf = f.ReadToEnd();
                _song = JsonSerializer.Deserialize<Song>(sf);
                LoadData();
            }
        }

        private void LoadData()
        {
            txtSongName.Text = _song.Name;
            txtBaseNote.Text = _song.BaseNote.ToString();
            txtDuration.Text = _song.Duration.ToString();
            _trackEditor.Tracks = _song.Tracks;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Diminished Jazz Scale
            var scale = new int[] { 3, 5, 6, 8, 9, 11, 12, 14, 15 };

            using var seq = new Sequence();

            _song.Tracks = _trackEditor.Tracks;

            seq.AlgoB(_song);

            seq.Save("testWinMuse4.mid");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void txtSongName_KeyUp(object sender, KeyEventArgs e)
        {
            _song.Name = txtSongName.Text;
        }

        private void txtBaseNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(txtBaseNote.Text, out int res))
            {
                _song.BaseNote = res;
            }
        }

        private void txtDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(txtDuration.Text, out int res))
            {
                _song.Duration = res;
            }
        }
    }
}
