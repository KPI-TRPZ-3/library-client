using System.Collections.Generic;
using library_client.Models;

namespace library_client.DAL.Abstract.Repository
{
    /// <summary>
    ///     The base Repository interface.
    /// </summary>
    /// <typeparam name="TEntity">The Entity</typeparam>
    /// <typeparam name="TId">Type of Primary Key of the entity.</typeparam>
    public interface IRepository<TEntity, in TId>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        /// <summary>
        ///     Allows to get all entities of the model.
        /// </summary>
        /// <returns>The list of all entities.</returns>
        IEnumerable<TEntity> GetAll();
        
        /// <summary>
        ///     Allows to find the entity with the given ID.
        /// </summary>
        /// <param name="id">ID of the entity.</param>
        /// <returns>Found entity</returns>
        TEntity GetById(TId id);
        
        /// <summary>
        ///     Creates new entity.
        /// </summary>
        /// <param name="entity">The graph of the entity.</param>
        /// <returns>Created entity.</returns>
        TEntity Create(TEntity entity);
        
        /// <summary>
        ///     Saves entity changes.
        /// </summary>
        /// <param name="entity">The graph of updated entity.</param>
        void Update(TEntity entity);
        
        /// <summary>
        ///    Removes the given entity.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        void Delete(TEntity entity);
    }
}