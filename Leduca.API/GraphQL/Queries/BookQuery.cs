using GeneratedDtos;

namespace Leduca.API.GraphQL.Queries
{
    public class BookQuery
    {
        public IEnumerable<BookDto> GetBooks()
        {
            return new BookDto[0];
        }
    }
}
