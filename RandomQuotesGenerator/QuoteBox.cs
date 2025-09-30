using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomQuotesGenerator
{
    public static class QuoteBox
    {
        public static DialogResult Show(string message, string title = "Quote")
        {
            using (var form = new QuoteForm(message, title))
            {
                return form.ShowDialog(); // behaves like MessageBox.Show
            }
        }
    }
}
