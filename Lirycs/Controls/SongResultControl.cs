
using System.Windows.Forms;
using System;

namespace Lirycs
{
    public partial class SongResultControl : UserControl
    {
        public delegate void SongResultEventHandler(SongResultControl song);
        public event SongResultEventHandler SendSong;
        public SongResultControl()
        {
            InitializeComponent();
            songCover.Click += SongCover_Click;
            songArtist.Click += SongArtist_Click;
            songTitle.Click += SongTitle_Click;
        }

        private void SongTitle_Click(object sender, EventArgs e)
        {
            SendSong(this);
        }

        private void SongArtist_Click(object sender, EventArgs e)
        {
            SendSong(this);
        }

        private void SongCover_Click(object sender, EventArgs e)
        {
            SendSong(this);
        }

        public void SetSongInfo(string imageURL, string title, string artist, string lyricUrl)
        {
            songCover.ImageLocation = imageURL;
            songTitle.Text = title;
            songArtist.Text = artist;
            LyricsUrl.Text = lyricUrl;
        }

        public object getSongInfo()
        {


            return (
                 songCover.ImageLocation,
                 songTitle.Text,
                 songArtist.Text,
                  LyricsUrl.Text);
        }

        public string getLyricUrl()
        {

            return LyricsUrl.Text;
        }

    }
}
