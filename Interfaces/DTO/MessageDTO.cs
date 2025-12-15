using DomainModel;
using System;

namespace Interfaces.DTO
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }
        public bool FromClient { get; set; }

        public MessageDTO()
        {
        }

        public MessageDTO(Message message)
        {
            Id = message.Id;
            OrderId = message.OrderId;
            Text = message.Text;
            SentAt = message.SentAt;
            FromClient = message.FromClient;
        }
    }
}
