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
        public int Create(PizzaBaseCreateDTO DTO);

        public void Update(PizzaBaseUpdateDTO DTO);

        public void Delete(int Id);
    }
}
