using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace library_client.Models
{
    /// <summary>
    ///     The base class of models.
    /// </summary>
    /// <typeparam name="T">Type of a primary key of a model.</typeparam>
    public abstract class BaseEntity<T> where T : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public T Id { get; set; }

        [JsonProperty("id")]
        private T IdSetter
        {
            set => Id = value;
        }
    }}
}