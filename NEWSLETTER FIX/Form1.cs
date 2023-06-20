using NEWSLETTER_FIX.Models;
using Npgsql;

namespace NEWSLETTER_FIX
{
    public partial class Form1 : Form
    {
        NewsletterContext newsletterContext = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            newsletterContext.ReadAll();
            List<Newsletter> newsletters;
            newsletters = newsletterContext.Newsletters;

            flpNewsletter.Controls.Clear();

            foreach (var newsletter in newsletters.TakeLast(3))
            {
                PictureBox newsItem = new NewsletterItem(newsletter).CreateItem();
                newsItem.Text = newsletter.Title;
                flpNewsletter.Controls.Add(newsItem);
            }

            flpNewsletter.Controls.Add(btnAddNews);
        }

        private void flpNewsletter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}