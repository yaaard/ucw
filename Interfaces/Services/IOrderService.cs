using DomainModel;
using Interfaces.DTO;
using System.Collections.Generic;

namespace Services
{
    public interface IOrderService
    {
        /// <returns></returns>
        List<OrderDTO> GetAllOrders();
        /// <param name="openOrCloseID"></param>
        /// <returns></returns>
        List<OrderDTO> GetFinishedOrders(int _id);
        List<OrderDTO> GetInProgressOrders(int _id);
        OrderDTO MakeOrder(OrderDTO p);
        /// <param name="dTO"></param>
        /// <param name="descript"></param>
        /// <param name="summ"></param>
        void CreateOrderWithService(OrderDTO dTO, string descript, int summ, int _id);
        OrderDTO GetOrder(int orderrId);

        void UpdetePosition(OrderDTO p, Position position, int _id);
        void UpdetePositionWithReject(OrderDTO p, Position position, int _id);
         void DeleteOrder(int id);
        void CreateOrderWithService(OrderDTO dTO, int _id);
    }
}
