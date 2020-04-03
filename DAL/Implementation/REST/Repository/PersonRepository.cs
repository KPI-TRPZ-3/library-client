using System;
using System.Net.Http;
using library_client.DAL.Abstract.Repository;
using library_client.Models;

namespace library_client.DAL.Implementation.REST.Repository
{
    public abstract class PersonRepository<TPersonEntity> :
        Repository<TPersonEntity, int>, IPersonRepository<TPersonEntity>
        where TPersonEntity : Person
    {
        protected PersonRepository(HttpClient client, string basePath, string pathSegment) : base(client, basePath,
            pathSegment)
        {
        }

        public TPersonEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}