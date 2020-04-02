using library_client.Models;

namespace library_client.DAL.Abstract.Repository
{
    /// <summary>
    ///     Repository interface for entities inherited from Person.
    /// </summary>
    /// <typeparam name="T">Entity inherited from Person.</typeparam>
    public interface IPersonRepository<T> : IRepository<T, int> where T : Person
    {
        /// <summary>
        ///     Finds a person by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Found person.</returns>
        T GetByName(string name);
    }
}