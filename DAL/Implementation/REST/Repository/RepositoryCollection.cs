using System.Net.Http;
using library_client.DAL.Abstract.Repository;

namespace library_client.DAL.Implementation.REST.Repository
{
    public class RepositoryCollection : IRepositoryCollection
    {
        public RepositoryCollection(HttpClient client, string basePath)
        {
            AuthorRepository = new AuthorRepository(client, basePath);
            BookRepository = new BookRepository(client, basePath);
            HistoryRepository = new HistoryRepository(client, basePath);
            ReaderRepository = new ReaderRepository(client, basePath);
        }

        public IAuthorRepository AuthorRepository { get; }
        public IBookRepository BookRepository { get; }
        public IHistoryRepository HistoryRepository { get; }
        public IReaderRepository ReaderRepository { get; }
    }
}