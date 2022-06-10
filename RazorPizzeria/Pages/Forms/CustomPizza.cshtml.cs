using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Pages.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 2;
            if (Pizza.Cheese) PizzaPrice = 3;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Pepperoni) PizzaPrice += 4;
            if (Pizza.Beef) PizzaPrice += 5;
            if (Pizza.Ham) PizzaPrice += 5;
            if (Pizza.Mushrooms) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
