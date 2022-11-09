using Microsoft.EntityFrameworkCore;
using System.Net;

namespace TaskTest
{
    public class Service
    {
        private readonly DBContext _db;
        public async Task<HttpResponseMessage> GetLibraryBooks(int libraryID)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var library = _db.libraries.AsNoTracking().Where(_ => _.ID == libraryID).SingleOrDefaultAsync();
            if (library == null)
            {
                response.StatusCode = HttpStatusCode.NotFound; // 404 code
            }
            else
            {
                var list = await _db.books.AsNoTracking().Where(_ => _.LibraryId == libraryID).ToListAsync();
                response.StatusCode = HttpStatusCode.OK; // 200 code
            }
            return response;
        }

        public async Task<HttpResponseMessage> AddBook(Book book)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            var library = _db.libraries.AsNoTracking().Where(_ => _.ID == book.LibraryId).SingleOrDefaultAsync();
            if (library == null)
            {
                response.StatusCode = HttpStatusCode.NotFound; // 404 code
            }
            else
            {
                // code for adding book
                response.StatusCode = HttpStatusCode.Created; // 201 code
            }

            return response;
        }
        public async Task<HttpResponseMessage> DeleteLibrary(int libraryID)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var library = _db.libraries.AsNoTracking().Where(_ => _.ID == libraryID).SingleOrDefaultAsync();
            if (library == null)
            {
                response.StatusCode = HttpStatusCode.NotFound; // 404 code
            }
            else
            {
                // code for delete the library
                response.StatusCode = HttpStatusCode.NoContent; // 204 code
            }
            return response;
        }
    }
}
