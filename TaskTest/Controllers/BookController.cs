using Microsoft.AspNetCore.Mvc;

namespace TaskTest.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class BookController : Controller
    {
         Service service=new Service();

        [HttpPost(Name = "AddBook")]
        public async Task<IActionResult> AddBook(Book book)
        {
            var result = await service.AddBook(book);
            return Ok(result);
        }
    }

}
