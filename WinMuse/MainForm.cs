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
            menuFileNew.Click += MenuFileNew_Clicked;
            menuFileOpen.Click += MenuFileOpen_ItemClicked;
            menuFileSave.Click += MenuFileSave_ItemClicked;
            menuExport.Click += MenuExport_Clicked;

            _trackEditor = new TrackEditor();
            pnlMain.Controls.Add(_trackEditor);
            _trackEditor.Dock = DockStyle.Fill;
            _trackEditor.Padding = new Padding(10);

            _song = new Song();
        }

        private void MenuExport_Clicked(object sender, EventArgs e)
        {
            if (_song.Tracks.Length > 0)
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    using var seq = new Sequence();

                    _song.Tracks = _trackEditor.Tracks;

                    seq.AlgoC(_song);

                    seq.Save(saveFileDialog2.FileName);
                }
            }
        }

        private void MenuFileNew_Clicked(object sender, EventArgs e)
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

        private void MenuFileSave_ItemClicked(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _song.Tracks = _trackEditor.Tracks;
                var songJson = JsonSerializer.Serialize(_song);
                using var songFile = File.CreateText(saveFileDialog1.FileName);
                songFile.Write(songJson);
            }
        }

        private void MenuFileOpen_ItemClicked(object sender, EventArgs e)
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

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void TxtSongName_KeyUp(object sender, KeyEventArgs e)
        {
            _song.Name = txtSongName.Text;
        }

        private void TxtBaseNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(txtBaseNote.Text, out int res))
            {
                _song.BaseNote = res;
            }
        }

        private void TxtDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(txtDuration.Text, out int res))
            {
                _song.Duration = res;
            }
        }
    }
}
