using System.Collections.Generic;
using library_client.Models;

namespace library_client.DAL.Abstract.Repository
{
    /// <summary>
    ///     Repository interface of author model.
    /// </summary>
    public interface IAuthorRepository : IPersonRepository<Author>
    {
        /// <summary>
        ///     Find a list of authors related with the given book.
        /// </summary>
        /// <param name="book">The book for which you need to find authors.</param>
        /// <returns>The list of authors of the given book.</returns>
        IEnumerable<Author> GetByBook(Book book);
    }
}