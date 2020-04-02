using library_client.Models;

namespace library_client.DAL.Abstract.Repository
{
    /// <summary>
    ///     History repository interface.
    /// </summary>
    public interface IHistoryRepository : IRepository<HistoryRecord, int>
    {
    }
}