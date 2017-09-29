using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class frm_clock : Form
    {
        public frm_clock ()
        {
            InitializeComponent();
        }

        private void timer1_Tick (object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frm_clock_Load (object sender, EventArgs e)
        {
            this.Text += " v" + Application.ProductVersion;
        }
    }
}
