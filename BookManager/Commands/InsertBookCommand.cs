using BookApp.Data;
using BookManager.DTOs;
using MediatR;

namespace BookManager.Commands
{

    public record InsertBookCommand(int Id, string ISBN, string Title, string ShortDescription, DateTime PubliccationYear, string Language, int AuthorId) : IRequest<Book>;
    //public class InsertBookCommand : IRequest<Book>
    //{
    //    public int Id { get; set; }
    //    public string ISBN { get; set; }
    //    public string Title { get; set; }
    //    public string ShortDescription { get; set; }
    //    public DateTime PublicationYear { get; set; }
    //    public string Language { get; set; }
    //    public int AuthorId { get; set; }
    //    public InsertBookCommand(int id, string iSBN,string title, string shortDescription, DateTime publiccationYear, string language, int authorId)
    //    {
    //        Id=id;
    //        ISBN=iSBN;
    //        Title=title;
    //        ShortDescription=shortDescription;
    //        PublicationYear=publiccationYear;
    //        Language=language;
    //        AuthorId=authorId;
    //    }
    //}
}
