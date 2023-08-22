using BookApp.Data.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data.Handlers
{
    public class GetBookListHandler : IRequestHandler<GetBookListQuery, List<Book>>
    {
        
        public GetBookListHandler( )
        {
                
        }
        public Task<List<Book>> Handle(GetBookListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult( new List<Book>() );
        }
    }
}
