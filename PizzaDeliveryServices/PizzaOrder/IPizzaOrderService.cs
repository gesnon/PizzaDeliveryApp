using PizzaDeliveryServices.DTO.PizzaOrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IPizzaOrderService
    {
        public void CreatePizzaOrder(PizzaOrderCreateDTO DTO);

        public void UpdatePizzaOrder(PizzaOrderUpdateDTO DTO);

        public void DeletePizzaOrder(int Id);
    }
}
