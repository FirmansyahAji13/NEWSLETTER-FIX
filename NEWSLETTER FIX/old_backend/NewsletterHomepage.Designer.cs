namespace NEWSLETTER_FIX
{
    partial class NewsletterHomepage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpanelnewsletter = new FlowLayoutPanel();
            btnAddNews = new Button();
            btnNewsLetter1 = new Button();
            btnNewsLetter2 = new Button();
            btnNewsLetter3 = new Button();
            flpanelnewsletter.SuspendLayout();
            SuspendLayout();
            // 
            // flpanelnewsletter
            // 
            flpanelnewsletter.AutoScroll = true;
            flpanelnewsletter.Controls.Add(btnAddNews);
            flpanelnewsletter.Location = new Point(3, 3);
            flpanelnewsletter.Name = "flpanelnewsletter";
            flpanelnewsletter.Size = new Size(768, 248);
            flpanelnewsletter.TabIndex = 5;
            // 
            // btnAddNews
            // 
            btnAddNews.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNews.BackColor = Color.Transparent;
            btnAddNews.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnAddNews.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAddNews.FlatStyle = FlatStyle.Flat;
            btnAddNews.Location = new Point(3, 3);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(250, 100);
            btnAddNews.TabIndex = 1;
            btnAddNews.Text = "New +";
            btnAddNews.UseVisualStyleBackColor = false;
            btnAddNews.Click += BtnAddNews_Click;
            // 
            // btnNewsLetter1
            // 
            btnNewsLetter1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewsLetter1.BackColor = SystemColors.GrayText;
            btnNewsLetter1.BackgroundImageLayout = ImageLayout.None;
            btnNewsLetter1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNewsLetter1.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNewsLetter1.FlatStyle = FlatStyle.Flat;
            btnNewsLetter1.Location = new Point(3, 109);
            btnNewsLetter1.Name = "btnNewsLetter1";
            btnNewsLetter1.Size = new Size(250, 100);
            btnNewsLetter1.TabIndex = 2;
            btnNewsLetter1.Text = "Newsletter Thumbnail";
            btnNewsLetter1.UseVisualStyleBackColor = false;
            // 
            // btnNewsLetter2
            // 
            btnNewsLetter2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewsLetter2.BackColor = SystemColors.GrayText;
            btnNewsLetter2.BackgroundImageLayout = ImageLayout.None;
            btnNewsLetter2.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNewsLetter2.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNewsLetter2.FlatStyle = FlatStyle.Flat;
            btnNewsLetter2.Location = new Point(259, 3);
            btnNewsLetter2.Name = "btnNewsLetter2";
            btnNewsLetter2.Size = new Size(250, 100);
            btnNewsLetter2.TabIndex = 3;
            btnNewsLetter2.Text = "Newsletter Thumbnail";
            btnNewsLetter2.UseVisualStyleBackColor = false;
            // 
            // btnNewsLetter3
            // 
            btnNewsLetter3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewsLetter3.BackColor = SystemColors.GrayText;
            btnNewsLetter3.BackgroundImageLayout = ImageLayout.None;
            btnNewsLetter3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNewsLetter3.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnNewsLetter3.FlatStyle = FlatStyle.Flat;
            btnNewsLetter3.Location = new Point(259, 109);
            btnNewsLetter3.Name = "btnNewsLetter3";
            btnNewsLetter3.Size = new Size(250, 100);
            btnNewsLetter3.TabIndex = 4;
            btnNewsLetter3.Text = "Newsletter Thumbnail";
            btnNewsLetter3.UseVisualStyleBackColor = false;
            // 
            // NewsletterHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(flpanelnewsletter);
            Name = "NewsletterHomepage";
            Size = new Size(774, 254);
            Load += NewsletterHomepage_Load;
            flpanelnewsletter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpanelnewsletter;
        private Button btnNewsLetter1;
        private Button btnNewsLetter2;
        private Button btnNewsLetter3;
        private Button btnAddNews;
    }
}
