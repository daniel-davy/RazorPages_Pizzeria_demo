using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Pages.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 4, TomatoSauce=true, Beef=true, FinalPrice=6},
            new PizzasModel() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 3, TomatoSauce=true, Cheese=true, FinalPrice=5},
            new PizzasModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 3, TomatoSauce=true, Cheese=true, Pepperoni=true, FinalPrice=7},
            new PizzasModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 3, TomatoSauce=true, Cheese=true, Mushrooms=true, Beef=true, FinalPrice=7},
            new PizzasModel() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 3, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice=6},
            new PizzasModel() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 3, TomatoSauce=true, Cheese=true, Beef=true, Ham=true, Mushrooms=true, FinalPrice=15},
            new PizzasModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 3, TomatoSauce=true, Cheese=true, Pineapple=true, FinalPrice=12},
            new PizzasModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, TomatoSauce=true, Mushrooms=true, FinalPrice=4},
            new PizzasModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 4, TomatoSauce=true, Mushrooms=true, Pineapple=true, FinalPrice=11}
        
            
        };
        public void OnGet()
        {
        }
    }
}
