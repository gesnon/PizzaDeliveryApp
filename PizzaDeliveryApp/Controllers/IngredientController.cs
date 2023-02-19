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

        [HttpGet("{Id}")]
        public ActionResult Get(int Id)
        {
            return Ok (ingredientService.Get(Id));
        }

        [HttpGet("GetByName/{Name?}")]
        public ActionResult GetByName(string? Name=null)
        {
            return Ok(ingredientService.GetByName(Name));
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int Id)
        {
            return Ok(ingredientService.Delete(Id));
        }

        [HttpPut("Update")]
        public ActionResult Update([FromBody] IngredientUpdateDTO DTO)
        {
            ingredientService.Update(DTO);
            return Ok();
        }        
             
        
    }
}
