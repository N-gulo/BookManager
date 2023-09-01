using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public DateTime PublicationYear { get; set; }
        public string Language { get; set; }
        public int AuthorId { get; set; }
        public  virtual Author Author { get; set; }
    }
}
