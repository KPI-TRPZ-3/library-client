using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace library_client.Models
{
    public class AuthorBook
    {
        [Required] [JsonProperty("authorId")] public int AuthorId { get; set; }

        [Required] [JsonIgnore] public Author Author { get; set; }

        [Required] [JsonProperty("bookId")] public int BookId { get; set; }

        [Required] [JsonIgnore] public Book Book { get; set; }
    }
}