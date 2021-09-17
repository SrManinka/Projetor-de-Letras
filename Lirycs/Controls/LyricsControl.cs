using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lirycs.Controls
{
    public partial class LyricsControl : UserControl
    {
        public LyricsControl()
        {
            InitializeComponent();

        }
        private string[] lyrics;
        private SecondScreen secondScreen;
        private LyricsResultControl[] lyricsOptions;
        private bool isSecondScreen = false;
        private int selectedControl = 0;
        //public event ErrorEventHandler SendError;

        public void SetLyrics(string[] incomingLyrics)
        {
            Console.WriteLine(incomingLyrics[0]);
            selectedControl = 0;
            lyrics = incomingLyrics;
            SetLyricsList();
            SelectOption();
            isScreen.Checked = true;
        }

        private void isScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (!isSecondScreen)
            {
                secondScreen = new SecondScreen();
                Screen[] screens = Screen.AllScreens;
                Screen screen = screens[1];
                //Console.WriteLine(screen);
                Rectangle area = screen.WorkingArea;
                secondScreen.StartPosition = FormStartPosition.Manual;
                secondScreen.Location = new Point(area.X, area.Y);
                secondScreen.TopMost = true;
                secondScreen.Bounds = screen.Bounds;
                secondScreen.Show();
                SelectOption();
            }
            else
            {
                secondScreen.Close();
            }
            isSecondScreen = !isSecondScreen;
        }

        private void SetLyricsList()
        {
            if (lyricsOptions != null)
            {

                sideBar.Controls.Clear();
            }

            lyricsOptions = new LyricsResultControl[lyrics.Length];
            int resultSize = 0;
            int leftPadding = 8;
            for (int i = 0; i < lyrics.Length; i++)
                if (lyrics[1] == null)
                {
                    break;
                }
                else
                {
                    lyricsOptions[i] = new LyricsResultControl();
                    lyricsOptions[i].setLyric(lyrics[i]);

                    if (i == 0)
                    {

                        resultSize = lyricsOptions[i].Size.Height;
                        lyricsOptions[i].Top = 8;
                        lyricsOptions[i].Left = leftPadding;

                    }
                    else
                    {
                        lyricsOptions[i].Top = lyricsOptions[i - 1].Top + resultSize + 8;
                        lyricsOptions[i].Left = leftPadding;

                    }
                    sideBar.Controls.Add(lyricsOptions[i]);
                    lyricsOptions[i].Cursor = Cursors.Hand;

                    lyricsOptions[i].setLyricPosition(i.ToString());
                    lyricsOptions[i].IsClicked += lyricsOptions_Click;

                }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            changeSelectedControl("right");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            changeSelectedControl("left");
        }

        public void changeSelectedControl(string direction)
        {
            if (lyricsOptions != null)
            {
                if (direction == "left" && selectedControl - 1 >= 0)
                {
                    --selectedControl;
                }
                if (direction == "right" && selectedControl + 1 < lyricsOptions.Length)
                {
                    ++selectedControl;
                }
                SelectOption();
            }
        }

        private void lyricsOptions_Click(object sender)
        {

            LyricsResultControl lyricOption = sender as LyricsResultControl;
            selectedControl = int.Parse(lyricOption.getLyricPosition());
            SelectOption();

        }
        private void SelectOption()
        {
            if (lyricsOptions != null)
                foreach (LyricsResultControl option in lyricsOptions)
                {
                    if (int.Parse(option.getLyricPosition()) == selectedControl)
                    {
                        option.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
                        txtLyrics.Text = option.getLyric();
                        sideBar.AutoScrollPosition = new Point(-sideBar.AutoScrollPosition.X,
                                               -sideBar.AutoScrollPosition.Y + option.Location.Y);
                        if (secondScreen != null)
                            secondScreen.SetLyric(option.getLyric());
                    }
                    else
                    {
                        option.BackColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
                    }
                }
        }

        private void LyricsControl_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("key");
            if (e.KeyCode == Keys.Left)
            {
                changeSelectedControl("left");
            }
            else if (e.KeyCode == Keys.Right)
            {
                changeSelectedControl("right");
            }
        }
    }
}
