using PizzaDeliveryServices.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IOrderService
    {
        public void CreateOrder(OrderCreateDTO DTO);
        public void UpdateOrder(OrderUpdateDTO DTO);
        public void DeleteOrder(int Id);
        public List<OrderGetDTO> GetOrderHistory(int ClientID);
    }
}
