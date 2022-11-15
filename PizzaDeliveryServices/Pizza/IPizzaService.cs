using PizzaDeliveryServices.DTO.PizzaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IPizzaService
    {
        public void CreatePizza(PizzaCreateDTO DTO);

        public void UpdatePizza(PizzaUpdateDTO DTO);
        public void DeletePizza(int Id);
    }
}
