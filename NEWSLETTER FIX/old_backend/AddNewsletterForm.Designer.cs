namespace NEWSLETTER_FIX
{
    partial class AddNewsletterForm
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
            btnAddNews = new Button();
            lbNewsLink = new Label();
            lbNewsDescription = new Label();
            lbNewsTitle = new Label();
            tbNewsLink = new TextBox();
            tbNewsDescription = new TextBox();
            tbNewsTitle = new TextBox();
            btnCancelNews = new Button();
            datePickerNewsletter = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAddNews
            // 
            btnAddNews.Cursor = Cursors.Hand;
            btnAddNews.Location = new Point(167, 138);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(75, 23);
            btnAddNews.TabIndex = 4;
            btnAddNews.Text = "Add";
            btnAddNews.UseVisualStyleBackColor = true;
            btnAddNews.Click += BtnAddNews_Click;
            // 
            // lbNewsLink
            // 
            lbNewsLink.AutoSize = true;
            lbNewsLink.Location = new Point(39, 76);
            lbNewsLink.Name = "lbNewsLink";
            lbNewsLink.Size = new Size(29, 15);
            lbNewsLink.TabIndex = 8;
            lbNewsLink.Text = "Link";
            lbNewsLink.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNewsDescription
            // 
            lbNewsDescription.AutoSize = true;
            lbNewsDescription.Location = new Point(14, 47);
            lbNewsDescription.Name = "lbNewsDescription";
            lbNewsDescription.Size = new Size(54, 15);
            lbNewsDescription.TabIndex = 7;
            lbNewsDescription.Text = "Deskripsi";
            lbNewsDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNewsTitle
            // 
            lbNewsTitle.AutoSize = true;
            lbNewsTitle.Location = new Point(33, 18);
            lbNewsTitle.Name = "lbNewsTitle";
            lbNewsTitle.Size = new Size(35, 15);
            lbNewsTitle.TabIndex = 6;
            lbNewsTitle.Text = "Judul";
            lbNewsTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbNewsLink
            // 
            tbNewsLink.BorderStyle = BorderStyle.FixedSingle;
            tbNewsLink.Location = new Point(77, 74);
            tbNewsLink.Name = "tbNewsLink";
            tbNewsLink.Size = new Size(246, 23);
            tbNewsLink.TabIndex = 3;
            // 
            // tbNewsDescription
            // 
            tbNewsDescription.BorderStyle = BorderStyle.FixedSingle;
            tbNewsDescription.Location = new Point(77, 45);
            tbNewsDescription.Name = "tbNewsDescription";
            tbNewsDescription.Size = new Size(246, 23);
            tbNewsDescription.TabIndex = 2;
            // 
            // tbNewsTitle
            // 
            tbNewsTitle.BackColor = SystemColors.Window;
            tbNewsTitle.BorderStyle = BorderStyle.FixedSingle;
            tbNewsTitle.Location = new Point(77, 16);
            tbNewsTitle.Name = "tbNewsTitle";
            tbNewsTitle.Size = new Size(246, 23);
            tbNewsTitle.TabIndex = 1;
            // 
            // btnCancelNews
            // 
            btnCancelNews.Cursor = Cursors.Hand;
            btnCancelNews.Location = new Point(248, 138);
            btnCancelNews.Name = "btnCancelNews";
            btnCancelNews.Size = new Size(75, 23);
            btnCancelNews.TabIndex = 5;
            btnCancelNews.Text = "Cancel";
            btnCancelNews.UseVisualStyleBackColor = true;
            btnCancelNews.Click += BtnCancelNews_Click;
            // 
            // datePickerNewsletter
            // 
            datePickerNewsletter.Location = new Point(77, 103);
            datePickerNewsletter.Name = "datePickerNewsletter";
            datePickerNewsletter.Size = new Size(246, 23);
            datePickerNewsletter.TabIndex = 9;
            // 
            // AddNewsletterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1011, 495);
            Controls.Add(datePickerNewsletter);
            Controls.Add(btnCancelNews);
            Controls.Add(btnAddNews);
            Controls.Add(lbNewsLink);
            Controls.Add(lbNewsDescription);
            Controls.Add(lbNewsTitle);
            Controls.Add(tbNewsLink);
            Controls.Add(tbNewsDescription);
            Controls.Add(tbNewsTitle);
            Name = "AddNewsletterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNews;
        private Label lbNewsLink;
        private Label lbNewsDescription;
        private Label lbNewsTitle;
        private TextBox tbNewsLink;
        private TextBox tbNewsDescription;
        private TextBox tbNewsTitle;
        private Button btnCancelNews;
        private DateTimePicker datePickerNewsletter;
    }
}
