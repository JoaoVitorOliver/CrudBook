using Microsoft.AspNetCore.Mvc;
using Livros.livros.Application.Commands.Create;
using Livros.livros.Application.Handlers;
using Livros.livros.Domain.Models.Entities;
using Livros.livros.Application.Commands.Update;
using Livros.livros.Application.Validation;

namespace Livros.livros.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookHandler _handle;

        public BookController(BookHandler create)
        {
            _handle = create;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
        public IActionResult CreateBookController([FromBody] CreateBookCommand command)
        {
            var validator = new EntitieValidator();
            var results = validator.Validate(command);

            if (results.IsValid)
            {
                _handle.CreateBookHandle(command);
            }
            else
            {
                var error = results.Errors.Select(p => p.ErrorMessage);
                return BadRequest(error);
            }
            
            return Created(string.Empty, command);

        }

        [HttpGet]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]

        public IActionResult GetBookController()
        {
            var response = _handle.GetBookHandle();

            return Ok(response);
        }

        [HttpPut]
        public IActionResult UpdateBookController(int id, [FromBody] UpdateBookCommand command)
        {
            var response = _handle.UpdateBookHandle(id, command);

            return NoContent();
        }
    }
}