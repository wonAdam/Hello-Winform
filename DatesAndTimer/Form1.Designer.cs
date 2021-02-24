
namespace DatesAndTimer
{
    partial class frmDate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblDayOfTime = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDayOfMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(18, 116);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(36, 13);
            this.lblDayOfWeek.TabIndex = 0;
            this.lblDayOfWeek.Text = "Week";
            // 
            // lblDayOfTime
            // 
            this.lblDayOfTime.AutoSize = true;
            this.lblDayOfTime.Location = new System.Drawing.Point(18, 148);
            this.lblDayOfTime.Name = "lblDayOfTime";
            this.lblDayOfTime.Size = new System.Drawing.Size(30, 13);
            this.lblDayOfTime.TabIndex = 1;
            this.lblDayOfTime.Text = "Time";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(18, 59);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month";
            // 
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.AutoSize = true;
            this.lblDayOfMonth.Location = new System.Drawing.Point(18, 87);
            this.lblDayOfMonth.Name = "lblDayOfMonth";
            this.lblDayOfMonth.Size = new System.Drawing.Size(26, 13);
            this.lblDayOfMonth.TabIndex = 3;
            this.lblDayOfMonth.Text = "Day";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(18, 30);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timTime
            // 
            this.timTime.Interval = 1000;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 240);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDayOfMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDayOfTime);
            this.Controls.Add(this.lblDayOfWeek);
            this.Name = "frmDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblDayOfTime;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDayOfMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timTime;
    }
}

