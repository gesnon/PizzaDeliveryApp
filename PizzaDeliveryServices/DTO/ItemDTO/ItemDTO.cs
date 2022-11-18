using PizzaDeliveryDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.ItemDTO
{
    public class ItemDTO
    {
        public int ItemID { get; set; }
        public Size ItemSize { get; set; }
    }
}
