using System;
using System.Collections.Generic;
using System.Net.Http;
using library_client.DAL.Abstract.Repository;
using library_client.Models;

namespace library_client.DAL.Implementation.REST.Repository
{
    public class BookRepository : Repository<Book, int>, IBookRepository
    {
        public BookRepository(HttpClient client, string basePath) : base(client, basePath, "/books")
        {
        }

        public IEnumerable<Book> GetByReleaseDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Book GetByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}