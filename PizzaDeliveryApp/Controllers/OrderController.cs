using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryServices.DTO.ItemDTO;
using PizzaDeliveryServices.DTO.Order;
using PizzaDeliveryServices.Services;

namespace PizzaDeliveryApp.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class OrderController
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost("CreateOrder")]
        public void CreateOrder([FromBody]List<ItemDTO> DTO)
        {
            orderService.CreateOrder(DTO);
        }

        [HttpDelete("DeleteOrder/{Id}")]
        public void DeleteOrder(int Id)
        {
            orderService.DeleteOrder(Id);
        }

        [HttpGet("GetOrderHistory/{ClientID}")]        
        public List<OrderHistoryGetDTO> GetOrderHistory(int ClientID)
        {
            return orderService.GetOrderHistory(ClientID);
        }
    }
}
