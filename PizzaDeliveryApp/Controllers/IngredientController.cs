using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryServices.DTO.IngredientDTO;
using PizzaDeliveryServices.Services;
namespace PizzaDeliveryApp.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IngredientController : BaseController
    {
        private readonly IIngredientService ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            this.ingredientService = ingredientService;
        }


        [HttpPost("Create")]
        public ActionResult Create([FromBody] IngredientCreateDTO DTO)
        {
            return Ok(ingredientService.Create(DTO));
        }
    }
}
