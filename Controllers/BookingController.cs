
using Microsoft.AspNetCore.Mvc;
using flights_fullstack.Models;
using flights_fullstack.Dtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace flights_fullstack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        [HttpGet("{email}")]
        [ProducesResponseType(500)]
        [ProducesResponseType(400)]
        [ProducesResponseType(typeof(BookingModel), 200)]
        public ActionResult<IEnumerable<BookingModel>> List(string email)
        {
            var booking = new BookingModel(
                Guid.NewGuid(),
                "Air Serbia",
                "1000",
                2,
                email
                );

            return Ok(booking);
        }

        [HttpDelete]
        [ProducesResponseType(500)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Cancel(BookDto dto)
        {
            return NoContent();
        }
    }
}

