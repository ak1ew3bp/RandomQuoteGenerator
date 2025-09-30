using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RandomQuotesGenerator
{
    public partial class QuoteForm : Form
    {
        private readonly string quoteMessage;
        public QuoteForm(string message, string title = "Quote")
        {
            InitializeComponent();
            this.Text = title;

            lblQuote.Text = message;
            quoteMessage = message;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void picCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(quoteMessage);

                ToastForm toast = new ToastForm("Copied!");
                toast.StartPosition = FormStartPosition.Manual;

                var parent = this;

                // 🎯 Pick where you want it
                toast.Location = new Point(
                    parent.Left + (parent.Width - toast.Width) / 2,
                    parent.Top + parent.Height - toast.Height - 40
                );


                toast.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to copy: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
