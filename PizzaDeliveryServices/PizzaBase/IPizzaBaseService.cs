using PizzaDeliveryDB.Entities;
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

        public PizzaBase Get(int id);

        public PizzaBaseGetDTO GetDTO(int id);
        public void Update(PizzaBaseUpdateDTO DTO);

        public int Delete(int Id);
    }
}
