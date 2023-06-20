using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWSLETTER_FIX.Models
{
    public class Newsletter
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Link { get; set; }

        public Newsletter(DateOnly date, string title, string description, string link)
        {
            Date = date;
            Title = title;
            Description = description;
            Link = link;
        }

        public Newsletter(DateOnly date, string title, string description, string link, int id) : this(date, title, description, link)
            => this.Id = id;

    }
}
