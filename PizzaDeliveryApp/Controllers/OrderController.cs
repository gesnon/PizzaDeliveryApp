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
    public class OrderController: BaseController
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost("Create")]
        public ActionResult CreateOrder([FromBody]List<ItemDTO> DTO)
        {
            orderService.CreateOrder(DTO);

            return Ok();
        }

        [HttpDelete("Delete/{Id}")]
        public void DeleteOrder(int Id)
        {
            orderService.DeleteOrder(Id);
        }

        [HttpGet("History/{ClientID}")]        
        public List<OrderHistoryGetDTO> GetOrderHistory(int ClientID)
        {
            return orderService.GetOrderHistory(ClientID);
        }
    }
}
