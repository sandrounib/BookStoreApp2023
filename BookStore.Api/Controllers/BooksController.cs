using BookStore.Application.Query;
using BookStore.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GetBooksResponse> GetBooks(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetBooksResponse(), cancellationToken);
            return response;
        }

        [HttpPost]
        public async Task<IActionResult> SaveBook ([FromBody] Book book)
        {
            return Ok(book);
        }

        [HttpGet ("{bookId}")]
        public async Task<IActionResult> GetBook(string bookId)
        {
            return Ok(bookId);
        }

        [HttpPut ("{bookId}")]
        public async Task<IActionResult> UpdateeBook(string bookId, Book book)
        {
            return Ok(new {bookId = bookId, data = new { 
                title = book.Title} 
            });
        }

        [HttpDelete ("{bookId}")]
        public async Task<IActionResult> RemoveBook(string bookId)
        {
            return NoContent();
        }
       
    
    }
}
