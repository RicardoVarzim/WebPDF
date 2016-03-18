using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebPDF.Models
{
    public enum CommentType
    {
        Document, Project, News, Event
    }

    public class Comment
    {
        public int ID { get; set; }
        public virtual User user { get; set; }
        public string text { get; set; }
        public CommentType type { get; set; }
        public int DocId { get; set; }
    }
}
