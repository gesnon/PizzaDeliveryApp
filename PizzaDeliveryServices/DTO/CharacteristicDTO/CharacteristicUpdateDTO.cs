using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.CharacteristicDTO
{
    public class CharacteristicUpdateDTO
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Diameter { get; set; }
        public int Weight { get; set; }
        public int Size { get; set; }
    }
}
