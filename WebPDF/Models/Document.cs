using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebPDF.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEdit { get; set; }
        public virtual User user { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
