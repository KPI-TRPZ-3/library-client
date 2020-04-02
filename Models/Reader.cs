using System.Collections.Generic;
using Newtonsoft.Json;

namespace library_client.Models
{
    public class Reader : Person
    {
        /// <summary>
        ///     The list of the books that the reader takes in the moment.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        ///     The list of history records related with the reader.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<HistoryItem> History { get; set; }
    }
}