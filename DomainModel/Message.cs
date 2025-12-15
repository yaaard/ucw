using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    [Table("Message")]
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime SentAt { get; set; }

        /// <summary>
        /// True when the message is written by the client, false when by the executor.
        /// </summary>
        public bool FromClient { get; set; }

        public virtual Order Order { get; set; }
    }
}
