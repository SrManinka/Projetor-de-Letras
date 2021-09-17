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
    public partial class DisplayScreen : Form
    {
        public DisplayScreen()
        {
            InitializeComponent();
        }
        public void SetScreenNumber(string sNumber)
        {
            screenNumber.Text = sNumber;
        }


    }
}
