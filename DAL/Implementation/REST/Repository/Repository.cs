using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using library_client.DAL.Abstract.Repository;
using library_client.Models;
using Newtonsoft.Json;

namespace library_client.DAL.Implementation.REST.Repository
{
    public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId>, IDisposable
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        protected readonly HttpClient Client;

        protected readonly string PathUri;

        protected Repository(HttpClient client, string basePath, string pathUri)
        {
            Client = client;
            PathUri = $"{basePath.Trim('/')}/{pathUri.Trim('/')}";
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var json = Client.GetStringAsync(PathUri).Result;
            return JsonConvert.DeserializeObject<List<TEntity>>(json);
        }

        public TEntity GetById(TId id)
        {
            var json = Client.GetStringAsync($"{PathUri}/{id}").Result;
            return JsonConvert.DeserializeObject<TEntity>(json);
        }

        public TEntity Create(TEntity entity)
        {
            var json = JsonConvert.SerializeObject(entity,
                new JsonSerializerSettings {DateFormatString = "yyyy-MM-dd"});
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var msg = Client.PostAsync(PathUri, content).Result;
            if (msg.IsSuccessStatusCode)
                return entity;

            throw new Exception(msg.ReasonPhrase);
        }

        public void Update(TEntity entity)
        {
            var json = JsonConvert.SerializeObject(entity);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var msg = Client.PutAsync($"{PathUri}/{entity.Id}", httpContent).Result;
            if (!msg.IsSuccessStatusCode)
                throw new Exception(msg.ReasonPhrase);
        }

        public void Delete(TEntity entity)
        {
            var msg = Client.DeleteAsync($"{PathUri}/{entity.Id}").Result;
            if (!msg.IsSuccessStatusCode)
                throw new Exception(msg.ReasonPhrase);
        }
    }
}