using AutoMapper;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.PizzaOrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class PizzaOrderService: IPizzaOrderService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public PizzaOrderService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void CreatePizzaOrder(PizzaOrderCreateDTO DTO)
        {
            PizzaOrder pizzaOrder = mapper.Map<PizzaOrder>(DTO);

            context.PizzaOrders.Add(pizzaOrder);
            context.SaveChanges();
        }
        public void UpdatePizzaOrder(PizzaOrderUpdateDTO DTO)
        {
            PizzaOrder pizzaOrder = context.PizzaOrders.FirstOrDefault(_ => _.Id == DTO.Id);
            if(pizzaOrder == null)
            {
                throw new NotFoundExeption("Товар не найден");
            }
            pizzaOrder= mapper.Map<PizzaOrder>(DTO);
            context.SaveChanges();
        }
        public void DeletePizzaOrder(int Id)
        {
            PizzaOrder pizzaOrder = context.PizzaOrders.FirstOrDefault(_ => _.Id ==Id);
            if (pizzaOrder == null)
            {
                throw new NotFoundExeption("Товар не найден");
            }
            context.PizzaOrders.Remove(pizzaOrder);
            context.SaveChanges();
        }

    }
}
