using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace library_client.Models
{
    /// <summary>
    ///     A book.
    /// </summary>
    public class Book : BaseEntity<int>
    {
        /// <summary>
        ///     The name of the book.
        /// </summary>
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        ///     The description of the book.
        /// </summary>
        [Required]
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     The release date of the book.
        /// </summary>
        [Required]
        [JsonProperty("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("readerId")] public int? ReaderId { get; set; }

        /// <summary>
        ///     The list of authors of the book.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }

        /// <summary>
        ///     The reader who takes the book in the moment.
        /// </summary>
        [JsonIgnore]
        public virtual Reader Reader { get; set; }

        /// <summary>
        ///     The history readers taking the book.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<HistoryRecord> History { get; set; }

        /// <summary>
        ///     The sections of the book.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<Charter> Charters { get; set; }
    }
}