using Interfaces.DTO;
using System.Collections.Generic;

namespace Services
{
    public interface IMessageService
    {
        List<MessageDTO> GetMessagesForOrder(int orderId);

        MessageDTO SendMessage(int orderId, string text, bool fromClient);
    }
}
