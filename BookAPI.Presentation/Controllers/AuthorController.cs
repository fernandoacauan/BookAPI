using BookAPI.Application.DTOs.Author;
using BookAPI.Application.UseCaseImplementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorUseCase _author;

        public AuthorController(IAuthorUseCase author)
        {
            _author = author;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _author.GetAllAsync();

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _author.GetByIdAsync(id);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorDto authorDto)
        {
            var response = await _author.CreateAuthorAsync(authorDto);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorDto authorDto)
        {
            var response = await _author.UpdateAuthorAsync(authorDto);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var response = await _author.DeleteAsync(id);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
