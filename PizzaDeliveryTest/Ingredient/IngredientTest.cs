using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.IngredientDTO;
using PizzaDeliveryServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryTest.IngredientTest
{
    public class IngredientTest: BaseTestFixture
    {
        [Test]
        public void CreateIngredient()
        {
            using (var scope = Testing._scopeFactory.CreateScope())
            {
                var IngredientService = scope.ServiceProvider.GetRequiredService<IIngredientService>();

                IngredientCreateDTO testIngredient = new IngredientCreateDTO { Name = "Сыр" };

                int ID = IngredientService.Create(testIngredient);

                Ingredient ingredient = IngredientService.Get(ID);

                ingredient.Id.Should().Be(ID);
                ingredient.Name.Should().Be(testIngredient.Name);
                
            }
        }
    }
}
