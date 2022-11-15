using AutoMapper;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class OrderService : IOrderService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public OrderService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void CreateOrder(OrderCreateDTO DTO)
        {
            Order order = mapper.Map<Order>(DTO);
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void UpdateOrder(OrderUpdateDTO DTO)
        {
            Order order = context.Orders.FirstOrDefault(_=>_.Id==DTO.Id);
            if (order == null)
            {
                throw new NotFoundExeption("Заказ не найден");
            }
            order = mapper.Map<Order>(DTO);
            context.SaveChanges();
        }

        public void DeleteOrder(int Id)
        {
            Order order = context.Orders.FirstOrDefault(_ => _.Id ==Id);
            if (order == null)
            {
                throw new NotFoundExeption("Заказ не найден");
            }
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public List<OrderGetDTO> GetOrderHistory(int ClientID)
        {
            List<Order> orders = context.Orders.Where(_ => _.ClientID==ClientID).ToList();


        }
    }
}
