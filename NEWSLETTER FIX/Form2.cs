using NEWSLETTER_FIX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace NEWSLETTER_FIX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        public void SetNewsletter(Newsletter newsletter)
        {

            int Id.Value = newsletter.Id;
            dtptanggal.Value = newsletter.Date;
            tbdeskripsi.Text = newsletter.Description;
            tblink.Text = newsletter.Link;
            tbjudul.Text = newsletter.Title;

        }

        private void tbjudul_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbdeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtptanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbnewsletterheading_Click(object sender, EventArgs e)
        {

        }
    }
}
