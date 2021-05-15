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

        public MainForm()
        {
            InitializeComponent();
            menuFileOpen.Click += new EventHandler(this.menuFileOpen_ItemClicked);
            menuFileSave.Click += new EventHandler(this.menuFileSave_ItemClicked);
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
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Diminished Jazz Scale
            var scale = new int[] { 3, 5, 6, 8, 9, 11, 12, 14, 15 };

            using var seq = new Sequence();

            var Track = new Track
            {
                Period = 48,
                Affluence = 7,
                InPosition = 0,
                Name = "A"
            };

            var Track2 = new Track
            {
                Period = 96,
                Affluence = 7,
                InPosition = 0,
                Name = "B"
            };

            var song = new Song
            {
                Algorithm = Algorithm.B.ToString(),
                BaseNote = 30,
                Duration = 3600,
                Tracks = new Track[] { Track, Track2 }
            };

            seq.AlgoB(song);

            seq.Save("testWinMuse2.mid");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
