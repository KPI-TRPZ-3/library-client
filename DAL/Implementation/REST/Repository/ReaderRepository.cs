using System.Net.Http;
using library_client.DAL.Abstract.Repository;
using library_client.Models;

namespace library_client.DAL.Implementation.REST.Repository
{
    public class ReaderRepository : PersonRepository<Reader>, IReaderRepository
    {
        public ReaderRepository(HttpClient client, string basePath) : base(client, basePath, "/readers")
        {
        }
    }
}