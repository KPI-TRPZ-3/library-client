using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace library_client.Models
{
    /// <summary>
    ///     The base class of people.
    /// </summary>
    public abstract class Person : BaseEntity<int>
    {
        /// <summary>
        ///     Name of the person.
        /// </summary>
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Surname of the person.
        /// </summary>
        [Required]
        [JsonProperty("surname")]
        public string Surname { get; set; }
    }
}