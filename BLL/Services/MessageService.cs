using DomainModel;
using Interfaces.DTO;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class MessageService : IMessageService
    {
        private readonly IDbRepos db;

        public MessageService(IDbRepos repos)
        {
            db = repos;
        }

        public List<MessageDTO> GetMessagesForOrder(int orderId)
        {
            return db.Messages.GetList()
                .Where(m => m.OrderId == orderId)
                .OrderBy(m => m.SentAt)
                .Select(m => new MessageDTO(m))
                .ToList();
        }

        public MessageDTO SendMessage(int orderId, string text, bool fromClient)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("����� �⮩ �� �ண�.", nameof(text));

            var order = db.Orders.GetItem(orderId);
            if (order == null)
                throw new ArgumentException("������� �� ���ன�.", nameof(orderId));

            var message = new Message
            {
                OrderId = orderId,
                Text = text.Trim(),
                FromClient = fromClient,
                SentAt = DateTime.Now
            };

            db.Messages.Create(message);
            db.Save();

            return new MessageDTO(message);
        }
    }
}
