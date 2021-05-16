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
            menuFileNew.Click += (s, e) => { NewSong(); };
            menuFileOpen.Click += (s, e) =>
            {
                if (museOpenFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    using var f = File.OpenText(museOpenFileDialog.FileName);
                    var sf = f.ReadToEnd();
                    _song = JsonSerializer.Deserialize<Song>(sf);
                    LoadData();
                }
            };
            menuFileSave.Click += (s, e) =>
            {
                if (museSaveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _song.Tracks = _trackEditor.Tracks;
                    var songJson = JsonSerializer.Serialize(_song);
                    using var songFile = File.CreateText(museSaveFileDialog.FileName);
                    songFile.Write(songJson);
                }
            };
            menuExport.Click += (s, e) =>
            {
                if (_song.Tracks.Length > 0)
                {
                    if (midiSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using var seq = new Sequence();

                        _song.Tracks = _trackEditor.Tracks;

                        seq.AlgoC(_song);

                        seq.Save(midiSaveFileDialog.FileName);
                    }
                }
            };

            _trackEditor = new TrackEditor();
            pnlMain.Controls.Add(_trackEditor);
            _trackEditor.Dock = DockStyle.Fill;
            _trackEditor.Padding = new Padding(10);

            NewSong();
        }

        private void NewSong()
        {
            ClearData();
            txtDuration.Text = "7200";
            txtAlgorithm.Text = "C";
            _song = new Song
            {
                Algorithm = txtAlgorithm.Text
            };
        }

        private void ClearData()
        {
            txtSongName.Text = string.Empty;
            txtBaseNote.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtAlgorithm.Text = string.Empty;
            _trackEditor.Tracks = Array.Empty<Track>();
        }

        private void LoadData()
        {
            txtSongName.Text = _song.Name;
            txtBaseNote.Text = _song.BaseNote.ToString();
            txtDuration.Text = _song.Duration.ToString();
            txtAlgorithm.Text = _song.Algorithm;
            _trackEditor.Tracks = _song.Tracks;
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

        private void TxtAlgorithm_KeyUp(object sender, KeyEventArgs e)
        {
            _song.Algorithm = txtAlgorithm.Text;
        }
    }
}
