using BookAPI.Application.DTOs.Book;
using BookAPI.Application.UseCaseInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookUseCase _book;

        public BookController(IBookUseCase book)
        {
            _book = book;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _book.GetAllAsync();

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _book.GetByIdAsync(id);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookDto bookDto)
        {
            var response = await _book.CreateBookAsync(bookDto);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookDto bookDto)
        {
            var response = await _book.UpdateBookAsync(bookDto);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var response = await _book.DeleteAsync(id);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
