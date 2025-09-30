using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;

namespace RandomQuotesGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
    private async Task<string> GetRandomQuote()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "https://zenquotes.io/api/random";
            var response = await client.GetStringAsync(url);

            // Example JSON: [{"q":"Be yourself; everyone else is already taken.","a":"Oscar Wilde"}]
            var jsonDoc = JsonDocument.Parse(response);
            var root = jsonDoc.RootElement[0];
            string quote = root.GetProperty("q").GetString();
            string author = root.GetProperty("a").GetString();

            return $"\"{quote}\"\n- {author}";
        }
    }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Show loading indicator
                picLoading.Visible = true;
                btnGenerate.Enabled = false;

                // Fetch the quote
                string quote = await GetRandomQuote();

                // Hide loading indicator
                picLoading.Visible = false;
                btnGenerate.Enabled = true;

                // Show quote in custom QuoteBox
                QuoteBox.Show(quote, "Random Quote");
            }
            catch (Exception ex)
            {
                picLoading.Visible = false;
                btnGenerate.Enabled = true;
                QuoteBox.Show("Error fetching quote: " + ex.Message, "Error");
            }
        }

        private void github_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ak1ew3bp"; // replace with your GitHub URL
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // important for default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }
    }
}
