using System.Net.Http;
using library_client.DAL.Abstract.Repository;
using library_client.Models;

namespace library_client.DAL.Implementation.REST.Repository
{
    public class HistoryRepository : Repository<HistoryRecord, int>, IHistoryRepository
    {
        public HistoryRepository(HttpClient client, string basePath) : base(client, basePath, "")
        {
        }
    }
}