using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using NEWSLETTER_FIX;

namespace NEWSLETTER_FIX.Models
{
    public class NewsletterItem
    {
        private readonly string connectionString = "Host=localhost; Port=5433; Username=postgres; Password=12345678; Database=news_letter";
        PictureBox newsItem = new();
        Newsletter Newsletter;

        public NewsletterItem(Newsletter newsletter)
        {
            newsItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newsItem.BackgroundImageLayout = ImageLayout.Stretch;
            newsItem.Margin = new Padding(3, 2, 3, 2);
            newsItem.Name = "pbNewsletter";
            newsItem.Size = new Size(196, 56);
            newsItem.TabIndex = 8;
            newsItem.TabStop = false;
            newsItem.Click += NewsItem_Click;
            Newsletter = newsletter;
        }
        
        public PictureBox CreateItem()
        {
            return newsItem;
        }

        public void NewsItem_Click(object sender, EventArgs e)
        {
            using (Form2 updateForm = new Form2())
            {
                updateForm.SetNewsletter(Newsletter);
                updateForm.ShowDialog();
            }

        }
    }
}
