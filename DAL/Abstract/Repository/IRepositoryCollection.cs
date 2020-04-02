namespace library_client.DAL.Abstract.Repository
{
    /// <summary>
    /// Collection of library model repositories.
    /// </summary>
    public interface IRepositoryCollection
    {
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }
        IHistoryRepository HistoryRepository { get; }
        IReaderRepository ReaderRepository { get; }
    }
}