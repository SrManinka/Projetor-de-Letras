
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Lirycs
{
    public delegate void ErrorEventHandler(string error);
    public partial class Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            homeControl.SendError += onError;
            homeControl.SendLyrics += startLyrics;
            MouseDown += Main_MouseDown;
            header.MouseDown += Main_MouseDown;

        }


        private DisplayScreen[] monitor;
        private void BTNShowScreens_Click(object sender, EventArgs e)
        {
            if (monitor != null)
                foreach (DisplayScreen janela in monitor)
                {
                    janela.Close();

                }
            Screen[] screens = Screen.AllScreens;
            monitor = new DisplayScreen[screens.Length];


            //Creates a small square on screen showing the monitor number
            for (int i = 0; i < screens.Length; i++)
            {
                Screen screen = Screen.AllScreens[i];
                Rectangle area = screen.WorkingArea;

                monitor[i] = new DisplayScreen
                {
                    StartPosition = FormStartPosition.Manual
                };
                monitor[i].SetScreenNumber((i + 1).ToString());
                Point location = new Point(area.X, area.Y);
                monitor[i].Location = location;
                monitor[i].TopMost = true;

                monitor[i].Show();
            }

            Wait(3000);

            //close the windows with the numbers
            foreach (DisplayScreen janela in monitor)
            {
                janela.Close();
            }
        }

        public void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (monitor != null)
                Wait(2400);
            Close();
        }
        private void btnClose_Hover(object sender, EventArgs e)
        {

            btnClose.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = HeaderColor;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SelectButton(Button button)
        {
            ResetMenuBtn();
            button.BackColor = Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(106)))), ((int)(((byte)(138))))); ;
            selection.Top = button.Top;


        }
        private void ResetMenuBtn()
        {
            var btnColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            btnHome.BackColor = btnColor;
            btnLyrics.BackColor = btnColor;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectButton(btnHome);
            homeControl.BringToFront();

        }

        private void btnLyrics_Click(object sender, EventArgs e)
        {
            setLyricsControl();
        }
        private void setLyricsControl()
        {
            SelectButton(btnLyrics);
            lyricsControl.BringToFront();

        }
        private void onError(string error)
        {
            lblError.Text = error;
            Wait(3000);
            lblError.Text = "";
        }

        private void startLyrics(string[] lyrics)
        {
            setLyricsControl();
            lyricsControl.SetLyrics(lyrics);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("key");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (Controls.GetChildIndex(lyricsControl) == 0)
                switch (keyData)
                {
                    case Keys.Right:
                        lyricsControl.changeSelectedControl("right");
                        return true;
                    case Keys.Left:
                        lyricsControl.changeSelectedControl("left");
                        return true;
                }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
