using System;
using System.Collections.Generic;
using System.Net.Http;
using library_client.DAL.Abstract.Repository;
using library_client.Models;

namespace library_client.DAL.Implementation.REST.Repository
{
    public class AuthorRepository : PersonRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(HttpClient client, string basePath) : base(client, basePath, "/authors")
        {
        }

        public IEnumerable<Author> GetByBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}