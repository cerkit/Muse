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
            saveFileDialog1.ShowDialog(this);
        }

        private void menuFileOpen_ItemClicked(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
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

            seq.AlgoB(_song);

            seq.Save("testWinMuse3.mid");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
