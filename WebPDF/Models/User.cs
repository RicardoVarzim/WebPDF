using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPDF.Models
{
    public enum Permission
    {
        Admin = 1,
        User = 0
    }

    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Permission Permission { get; set; }

        public virtual ICollection<DocumentType> DocPermissions { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<New> News { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}