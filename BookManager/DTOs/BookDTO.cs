using BookApp.Data;

namespace BookManager.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public DateTime PublicationYear { get; set; }
        public string Language { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorDTO Author { get; set; }
    }
}
