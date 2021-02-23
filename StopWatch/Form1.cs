using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }


        DateTime start;
        DateTime stop;
        TimeSpan elapsed;
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStop.Text = String.Empty;
            txtElapsed.Text = String.Empty;

            start = DateTime.Now;
            txtStart.Text = start.ToLongTimeString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (start != null)
            {
                stop = DateTime.Now;
                txtStop.Text = stop.ToLongTimeString();
                elapsed = stop - start;
                txtElapsed.Text = elapsed.Seconds.ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
