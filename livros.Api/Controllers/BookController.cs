using Microsoft.AspNetCore.Mvc;
using Livros.livros.Application.Commands.Create;
using Livros.livros.Application.Handlers;
using Livros.livros.Domain.Models.Entities;
using Livros.livros.Application.Validation;

namespace Livros.livros.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookHandler _handle;

        public BookController(BookHandler handle)
        {
            _handle = handle;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateBookController([FromBody] CreateBookCommand command)
        {
            var resultado = await _handle.CreateBookHandle(command);

            if (resultado.IsSuccess)
                return Created("", resultado);

            return BadRequest(resultado.Errors);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]

        public IActionResult GetBookController()
        {
            var response = _handle.GetBookHandle();

            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateBookController(int id, [FromBody] CreateBookCommand command)
        {
            var response = await _handle.UpdateBookHandle(id, command);

            if (response.IsSuccess)
                return NoContent();

            return BadRequest(response.Errors);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookController(int id)
        {
            var response = await _handle.DeleteBookHandle(id);
            if (response != null)
                return Ok();

            return BadRequest();
        }
    }
}