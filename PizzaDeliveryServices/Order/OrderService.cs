using AutoMapper;
using Microsoft.AspNetCore.Http;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.ItemDTO;
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
        private readonly Account account;

        public OrderService(ContextDB context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.mapper = mapper;
            this.account = (Account)httpContextAccessor.HttpContext.Items["User"];
        }

        public void CreateOrder(List<ItemDTO> DTO)
        {
            Order order = new Order { Date = DateTime.Now, ClientID = account.Id };
            order.PizzaOrders = DTO.Select(_ => new PizzaOrder
            {
                OrderId = order.Id,
                Pizza = new Pizza
                { PizzaBaseID = _.ItemID, Characteristic = context.Characteristics.FirstOrDefault(c => c.Size == _.ItemSize) }
            }).ToList();
            order.Price = order.PizzaOrders.Sum(_ => _.Pizza.Characteristic.Price);
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void UpdateOrder(OrderUpdateDTO DTO)
        {
            Order order = context.Orders.FirstOrDefault(_ => _.Id == DTO.Id);
            if (order == null)
            {
                throw new NotFoundExeption("Заказ не найден");
            }
            order = mapper.Map<Order>(DTO);
            context.SaveChanges();
        }

        public void DeleteOrder(int Id)
        {
            Order order = context.Orders.FirstOrDefault(_ => _.Id == Id);
            if (order == null)
            {
                throw new NotFoundExeption("Заказ не найден");
            }
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public List<OrderHistoryGetDTO> GetOrderHistory(int ClientID)
        {
            if (account.Role != Role.Admin)
            {
                ClientID = account.Id;
            }
            Account client = context.Accounts.FirstOrDefault(_ => _.Id == ClientID);

            if (client == null)
            {
                throw new NotFoundExeption("Клиент не найден");
            }

            List<Order> orders = context.Orders.Where(_ => _.ClientID == ClientID).ToList();

            List<OrderHistoryGetDTO> result = orders.Select(_ => mapper.Map<OrderHistoryGetDTO>(_)).ToList();

            return result;
        }
    }
}
