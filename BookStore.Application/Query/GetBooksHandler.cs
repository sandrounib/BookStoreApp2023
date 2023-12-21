using BookStore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Query
{
    public class GetBooksHandler : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {

        private readonly IBooksRepository _booksRepository;

        public GetBooksHandler(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public async Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var result = await _booksRepository.GetBooksAsync();
            return await Task.FromResult(new GetBooksResponse { Books = result });
        }
    }
}
