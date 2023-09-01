using BookApp.Data;
using BookApp.Data.Queries;
using BookManager.Commands;
using BookManager.DTOs;
using BookManager.Handlers;
using BookManager.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator mediator;

        public BookController(IMediator mediator)
        {
            this.mediator=mediator;
        }

        // GET: api/<BookController>
        [HttpGet]
        public async Task<IEnumerable<BookDTO>> Get()
        {
            return await mediator.Send(new GetBookListQuery());
        }

        //// GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<BookDTO> Get(int id)
        {
            return await mediator.Send(new GetBookByIdQuery() {id = id});
        }

        //// POST api/<BookController>
        [HttpPost]
        public async Task<Book> Post([FromBody] InsertBookCommand value)
        {
            return await mediator.Send(value);
        }

        //// PUT api/<BookController>/5
        [HttpPut]
        public async Task<int> Put([FromBody] UpdateBookCommand value)
        {
            return await mediator.Send(value);
        }

        //// DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await mediator.Send(new DeleteBookCommand() { Id = id });
        }

        //// SearchTitle api/<BookController>/5
        [HttpGet("search/{title}")]
        public async Task<IEnumerable<BookDTO>> SearchTitle(string title)
        {
            return await mediator.Send(new SearchBookByTitleQuery() { Title = title });
        }

    }
}
