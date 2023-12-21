using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infraestructure.Data
{
    public class BooksRepository : IBooksRepository
    {
        private readonly DataContext _context;

        public BooksRepository(DataContext context)
        {
            _context = context;
        }

        public Task DeleteBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public Task<Book> GetSingleBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveBookAsync(Book data)
        {
            await _context.Books.AddAsync(data);
            _context.SaveChanges();
        }

        public Task UpdateBook(Guid id, Book data)
        {
            throw new NotImplementedException();
        }
    }
}
