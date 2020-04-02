using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace library_client.Models
{
    public class HistoryRecord : BaseEntity<int>
    {
        /// <summary>
        ///     The date when the reader should return back the book.
        /// </summary>
        [Required]
        [JsonProperty("returnedDate")]
        public DateTime ReturnedDate { get; set; }

        /// <summary>
        ///     The date when the book has been returned.
        /// </summary>
        [JsonProperty("realReturnedDate")]
        public DateTime? RealReturnedDate { get; set; }

        /// <summary>
        ///     The date when the book has been taken.
        /// </summary>
        [Required]
        [JsonProperty("takenDate")]
        public DateTime TakenDate { get; set; }

        /// <summary>
        ///     The status of the book. E.g. "returned".
        /// </summary>
        [Required]
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("bookId")] public int BookId { get; set; }

        /// <summary>
        ///     The book related with the record.
        /// </summary>
        [Required]
        [JsonIgnore]
        public virtual Book Book { get; set; }

        [JsonProperty("readerId")] public int ReaderId { get; set; }

        /// <summary>
        ///     The reader related with the record.
        /// </summary>
        [Required]
        [JsonIgnore]
        public virtual Reader Reader { get; set; }
    }
}