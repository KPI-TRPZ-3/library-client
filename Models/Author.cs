using System.Collections.Generic;
using Newtonsoft.Json;

namespace library_client.Models
{
    /// <summary>
    ///     An author of the book.
    /// </summary>
    public class Author : Person
    {
        /// <summary>
        ///     The list of author books.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}