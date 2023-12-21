using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Interfaces
{
    public interface IBooksRepository
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task SaveBookAsync(Book data);
        Task <Book> GetSingleBookAsync(Guid id);
        Task UpdateBook(Guid id, Book data);
        Task DeleteBookAsync(Guid id);
    }
}
