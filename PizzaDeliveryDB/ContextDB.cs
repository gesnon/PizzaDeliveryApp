using Microsoft.EntityFrameworkCore;
using PizzaDeliveryDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryDB
{
    public class ContextDB: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<Order> Orders { get; set; }        
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaBase> pizzaBases { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public DbSet<PizzaBase> PizzaTemplates { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public ContextDB(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();                      
        }
    }
}
