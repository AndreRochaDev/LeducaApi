using GeneratedDtos;
using Leduca.API.DbModels;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Leduca.API.Services
{
    public interface IBookService
    {
        Task<BookDto?> GetBookAsync(Guid id);
        Task<IEnumerable<BookDto>> GetAllBooksAsync();
        Task<IEnumerable<BookQuizDto>> GetAllQuizesAsync();

    }

    public class BookService : IBookService
    {
        private readonly LeducaContext _context;
        public BookService(LeducaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookDto>> GetAllBooksAsync()
        {
            var books = await _context.Books.ToListAsync();
            return books.Select(b => b.Adapt<BookDto>());
        }

        public async Task<IEnumerable<BookQuizDto>> GetAllQuizesAsync()
        {
            var bookQuizzes = await _context.BookQuizzes
                .ToListAsync();

            return bookQuizzes.Select(b => b.Adapt<BookQuizDto>());
        }

        public async Task<BookDto?> GetBookAsync(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return null;
            return book.Adapt<BookDto>();
        }
    }
}
