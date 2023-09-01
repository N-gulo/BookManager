using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }

}
