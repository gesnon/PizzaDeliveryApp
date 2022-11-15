using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class NotFoundExeption: Exception
    {
        public NotFoundExeption()
        {

        }
        public NotFoundExeption(string Message) : base(Message)
        {

        }
    }
}
