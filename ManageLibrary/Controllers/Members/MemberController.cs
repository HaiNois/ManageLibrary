using ManageLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageLibrary.Controllers.Members
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly Library _library;

        public MemberController()
        {
            _library = new Library();
        }

        [HttpPost]
        public IActionResult RegisterMember(Member member)
        {
            _library.RegisterMember(member);
            return Ok("Member registered successfully.");
        }
        [HttpPost("borrow")]
        public IActionResult BorrowBook([FromQuery] string bookId, [FromQuery] string memberId)
        {
            bool success = _library.LendBook(bookId, memberId);
            if (success)
            {
                return Ok("Book borrowed successfully.");
            }

            return BadRequest("Failed to borrow the book.");
        }

        [HttpPost("return")]
        public IActionResult ReturnBook([FromQuery] string bookId, [FromQuery] string memberId)
        {
            _library.ReturnBook(bookId, memberId);
            return Ok("Book returned successfully.");
        }
    }
}
