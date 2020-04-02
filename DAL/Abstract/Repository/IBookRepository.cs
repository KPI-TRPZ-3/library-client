using System;
using System.Collections.Generic;
using library_client.Models;

namespace library_client.DAL.Abstract.Repository
{
    /// <summary>
    ///     Interface of book repository.
    /// </summary>
    public interface IBookRepository : IRepository<Book, int>
    {
        /// <summary>
        ///     Find books with the given release date.
        /// </summary>
        /// <param name="date">Release date of books.</param>
        /// <returns>The list of books satisfies the condition.</returns>
        IEnumerable<Book> GetByReleaseDate(DateTime date);

        /// <summary>
        ///     Find book by the given title.
        /// </summary>
        /// <param name="title">The title of book.</param>
        /// <returns>Found book.</returns>
        Book GetByTitle(string title);
    }
}