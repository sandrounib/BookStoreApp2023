using BookStore.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Query
{
    public class GetBooksResponse : IRequest<GetBooksResponse>
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
