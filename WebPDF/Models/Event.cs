using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebPDF.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HtmlText { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEdit { get; set; }
        public virtual User user { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Comment> AppliedUsers { get; set; }
    }
}
