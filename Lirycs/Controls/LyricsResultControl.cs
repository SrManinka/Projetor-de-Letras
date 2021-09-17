using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lirycs
{
    public delegate void LyricClickEventHandler(object self);
    public partial class LyricsResultControl : UserControl
    {

        public event LyricClickEventHandler IsClicked;
        public LyricsResultControl()
        {
            InitializeComponent();
        }

        public void setLyric(string lyric)
        {
            txtLyric.Text = lyric;
        }
        public string getLyric()
        {
            return txtLyric.Text;
        }
        public void setLyricPosition(string position)
        {
            txtLyricPosition.Text = position;
        }
        public string getLyricPosition()
        {
            return txtLyricPosition.Text;
        }

        private void txtLyric_Click(object sender, EventArgs e)
        {
            IsClicked?.Invoke(this);
        }

    }
}
