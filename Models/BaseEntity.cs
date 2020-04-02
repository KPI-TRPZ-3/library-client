using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace library_client.Models
{
    /// <summary>
    ///     The base class of models.
    /// </summary>
    /// <typeparam name="T">Type of primary key of the model.</typeparam>
    public abstract class BaseEntity<T> where T : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.Text.Json.Serialization.JsonIgnore]
        public T Id { get; set; }

        [JsonProperty("id")]
        private T IdSetter
        {
            set => Id = value;
        }
    }}
}