using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatesAndTimer
{
    public partial class frmDate : Form
    {
        public frmDate()
        {
            InitializeComponent();
        }

        bool isStarted = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!isStarted)
            {
                isStarted = true;
                timTime.Enabled = true;
                DateTime today = DateTime.Now;
                lblDayOfWeek.Text = today.DayOfWeek.ToString();
                lblMonth.Text = today.ToString("MMMM");
                lblYear.Text = today.Year.ToString();
                lblDayOfMonth.Text = today.Day.ToString();
                lblDayOfTime.Text = today.ToLongTimeString();

                btnStart.Text = "Exit";
            }
            else
            {
                Close();
            }
            
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            lblDayOfWeek.Text = today.DayOfWeek.ToString();
            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.Year.ToString();
            lblDayOfMonth.Text = today.Day.ToString();
            lblDayOfTime.Text = today.ToLongTimeString();
        }
    }
}
