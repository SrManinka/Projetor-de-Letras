using Lirycs.Classes;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lirycs
{
    public delegate void LyricsEventHandler(string[] lyrics);

    public partial class HomeControl : UserControl
    {
        private WebBrowser lyricsBrowser = new WebBrowser();
        private bool isLyric = false;
        private Hits[] songList;
        private const int maxSongs = 5;
        private SongResultControl[] songResult = new SongResultControl[5];
        private string[] lyrics;
        public event LyricsEventHandler SendLyrics;
        public event ErrorEventHandler SendError;

        public HomeControl()
        {
            InitializeComponent();

            lyricsBrowser.ScriptErrorsSuppressed = true;
            lyricsBrowser.DocumentCompleted += LyricsBrowser_DocumentCompleted;

            for (int i = 0; i < 5; i++)
            {
                songResult[i] = new SongResultControl();

                //songResult[i].Click += new EventHandler(BTNSoundResult_Click);
                songResult[i].SendSong += SongRecived;
            }
        }

        private void LyricsBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (!isLyric)
            {
                HtmlElementCollection divs = lyricsBrowser.Document.GetElementsByTagName("div");
                getLyrics(divs);
                //((Control)lyricsBrowser).Enabled = false;

            }
        }

        public void setLyricsBox(string lyrics)
        {
            lyricsBox.AppendText(lyrics);
        }
        public void setLyricsNull()
        {
            lyricsBox.Text = "";
        }


        public async Task SearchSong(string song)
        {
            try
            {
                IGeniusApiService geniusApi = RestService.For<IGeniusApiService>(Constants.MainUrl);
                var songResult = await geniusApi.GetSearchResponse(song);
                songList = songResult.Response.Hits;
                setSearchResults();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void setSearchResults()
        {

            int resultSize = 0;
            int leftPadding = 8;
            for (int i = 0; i < maxSongs; i++)
            {
                Hits song = songList[i];
                if (song == null)
                {
                    break;
                }
                else
                {

                    if (i == 0)
                    {

                        resultSize = songResult[i].Size.Height;
                        songResult[i].Top = 8;
                        songResult[i].Left = leftPadding;

                    }
                    else
                    {
                        songResult[i].Top = songResult[i - 1].Top + resultSize + 8;
                        songResult[i].Left = leftPadding;

                    }
                    sideBar.Controls.Add(songResult[i]);
                    songResult[i].Cursor = Cursors.Hand;
                    songResult[i].BringToFront();
                    songResult[i].SetSongInfo(song.Result.Song_Art_Image_Url, song.Result.Title, song.Result.Primary_Artist.Name, song.Result.Url);

                }
            }

        }

        private async void searchSong()
        {
            isLyric = false;
            string query = txtMusicInput.Text + " " + txtArtist.Text;
            if (query.Length > 3)
                await SearchSong(query);
            else
                SendError("Escreva pelo menos a letra, nome da música ou artista");

        }

        private void btnFindSong_Click(object sender, EventArgs e)
        {

            searchSong();
        }
        private void getLyrics(HtmlElementCollection divs)
        {
            isLyric = true;
            setLyricsNull();
            try
            {
                string incomingLyrics = "";
                foreach (HtmlElement link in divs)
                {
                    if (link.GetAttribute("className").Contains("Lyrics__Container"))
                    {
                        incomingLyrics += link.InnerText;
                    }
                }
                string[] stringSeparators = new string[] { "\n" };
                string[] lyricsList = incomingLyrics.Split(stringSeparators, StringSplitOptions.None);
                List<string> newLyricList = new List<string>();
                foreach (string line in lyricsList)
                    if (!line.Contains("[") && line.Length > 1)
                        newLyricList.Add(line);
                lyrics = newLyricList.ToArray();
                setLyrics(lyrics);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void setLyrics(string[] lyrics)
        {

            foreach (string line in lyrics)
            {
                setLyricsBox(line);
                setLyricsBox("\n");
            }
        }

        private void BTNSoundResult_Click(object sender, EventArgs e)
        {
            isLyric = false;
            SongResultControl song = sender as SongResultControl;
            lyricsBrowser.Navigate(song.getLyricUrl());
        }

        private void SongRecived(SongResultControl song)
        {
            isLyric = false;
            lyricsBrowser.Navigate(song.getLyricUrl());

        }

        private void btnProjectImage_Click(object sender, EventArgs e)
        {
            if (lyrics != null)
                SendLyrics?.Invoke(lyrics);
            else
                SendError?.Invoke("Selecione a musica.");

        }

        private void txtArtist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchSong();
            }
        }

        private void txtMusicInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchSong();
            }

        }
    }
}
