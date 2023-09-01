using BookManager.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data.Queries
{
    public record GetBookListQuery() : IRequest<IEnumerable<BookDTO>>;

}
