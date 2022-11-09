using Microsoft.AspNetCore.Mvc;

namespace TaskTest.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class LibrariesController : Controller
    {
        Service service = new Service();

        [HttpGet(Name = "GetLibraryBooks")]
        public async Task<IActionResult> GetLibraryBooks(int libraryID)
        {
            var result = await service.GetLibraryBooks(libraryID);
            return Ok(result);
        }

        [HttpPost(Name = "DeleteLibrary")]
        public async Task<IActionResult> DeleteSchoolBus(int libraryID)
        {
            var result = await service.DeleteLibrary(libraryID);
            return Ok(result);
        }

       
    }

}
