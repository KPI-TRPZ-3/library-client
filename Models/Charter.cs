using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace library_client.Models
{
    /// <summary>
    ///     The Charter of a book.
    /// </summary>
    public class Charter : BaseEntity<int>
    {
        /// <summary>
        ///     The title of the book.
        /// </summary>
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("bookId")] public int BookId { get; set; }

        /// <summary>
        ///     The book related with the charter.
        /// </summary>
        [Required]
        [JsonIgnore]
        public virtual Book Book { get; set; }
    }
}