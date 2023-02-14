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
        public int Create(PizzaCreateDTO DTO);
        public void Update(PizzaUpdateDTO DTO);
        public void Delete(int Id);
    }
}
