using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEWSLETTER_FIX.Models;

namespace NEWSLETTER_FIX
{
    public partial class NewsletterHomepage : UserControl
    {
        Models.NewsletterContext newsletterContext = new();
        public NewsletterHomepage()
        {
            InitializeComponent();
        }

        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            using AddNewsletterForm addNewsletterForm = new();
            addNewsletterForm.ShowDialog();
            //Newsletter news = newsletterContext.GetById(2);
            //MessageBox.Show(news.Title + news.Description + news.Link, news.Id.ToString());
            ShowItems();
        }

        private void NewsletterHomepage_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            newsletterContext.ReadAll();
            List<Newsletter> newsletters;
            newsletters = newsletterContext.Newsletters;

            flpanelnewsletter.Controls.Clear();

            foreach (var newsletter in newsletters.TakeLast(3))
            {
                PictureBox newsItem = new NewsletterItem(newsletter).CreateItem();
                newsItem.Text = newsletter.Title;
                flpanelnewsletter.Controls.Add(newsItem);
            }

            flpanelnewsletter.Controls.Add(btnAddNews);
        }
    }
}
