using PizzaDeliveryServices.DTO.PizzaBaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IPizzaBaseService
    {
        public void CreatePizzaBase(PizzaBaseCreateDTO DTO);

        public void UpdatePizzaBase(PizzaBaseUpdateDTO DTO);

        public void DeletePizzaBase(int Id);
    }
}
