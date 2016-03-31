using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPDF.Models;

namespace WebPDF.DAL
{
    public class SiteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SiteContext>
    {
        protected override void Seed(SiteContext context)
        {
            var documents = new List<Document>{
                new Document{ID=1,Description="",CreationDate= DateTime.Now,LastEdit=DateTime.Now,Name="Doc1",Path="/one1.pdf"},
                new Document{ID=2,Description="",CreationDate= DateTime.Now,LastEdit=DateTime.Now,Name="Doc2",Path="/one2.pdf"},
                new Document{ID=3,Description="",CreationDate= DateTime.Now,LastEdit=DateTime.Now,Name="Doc3",Path="/one3.pdf"},
                new Document{ID=4,Description="",CreationDate= DateTime.Now,LastEdit=DateTime.Now,Name="Doc4",Path="/one4.pdf"},
                new Document{ID=5,Description="",CreationDate= DateTime.Now,LastEdit=DateTime.Now,Name="Doc5",Path="/one5.pdf"},
                new Document{ID=6,Description="",CreationDate= DateTime.Now,LastEdit=DateTime.Now,Name="Doc6",Path="/one6.pdf"},


            };

            documents.ForEach(s => context.Documents.Add(s));
            context.SaveChanges();
        }
    }
}