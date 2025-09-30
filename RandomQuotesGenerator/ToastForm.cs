using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomQuotesGenerator
{
    public partial class ToastForm : Form
    {
        private System.Windows.Forms.Timer timer; // ✅ Explicit WinForms timer

        public ToastForm(string message)
        {
            InitializeComponent();

            lblMessage.Text = message;
            this.Size = new Size(200, 50);
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
            this.ShowInTaskbar = false;
            this.TopMost = true;

            // ✅ Use WinForms Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            timer.Start();
        }
    }
}
