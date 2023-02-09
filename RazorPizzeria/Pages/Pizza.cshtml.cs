using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita" ,
                PizzaName = "Margerita", BasePrice = 2,
                TomatoSauce=true ,
                Cheese=true ,
                FinalPrice = 4 },
            new PizzasModel(){ImageTitle="Hawaiian" ,
                PizzaName = "Hawaiian", BasePrice = 2,
                TomatoSauce=true ,
                Cheese=true ,
                Ham=true,
                Pineapple=true ,
                FinalPrice = 15 },
            new PizzasModel(){ImageTitle="Bolognese" ,
                PizzaName = "Bolognese", BasePrice = 2,
                TomatoSauce=true ,
                Beef=true,
                Cheese=true ,
                FinalPrice = 5 },
            new PizzasModel(){ImageTitle="Carbonara" ,
                PizzaName = "Carbonara", BasePrice = 2,
                TomatoSauce=true ,
                Cheese=true ,
                Ham = true,
                Mushroom=true,
                FinalPrice = 6 },
            new PizzasModel(){ImageTitle="Meatfeast" ,
                PizzaName = "Meatfeast", BasePrice = 2,
                Beef=true,
                Ham=true,
                Chicken=true,
                TomatoSauce=true ,
                Cheese=true ,
                FinalPrice = 7 },
            new PizzasModel(){ImageTitle="Seafood" ,
                PizzaName = "Seafood", BasePrice = 2,
                Tuna=true,
                TomatoSauce=true ,
                Cheese=true ,
                FinalPrice = 4 },
            new PizzasModel(){ImageTitle="Mushroom" ,
                PizzaName = "Mushroom", BasePrice = 2,
                Mushroom= true,
                TomatoSauce=true ,
                Cheese=true ,
                FinalPrice = 5 },
            new PizzasModel(){ImageTitle="Vegeterian" ,
                PizzaName = "Vegeterian", BasePrice = 2,
                TomatoSauce=true ,
                Cheese=true ,
                Mushroom=true,
                FinalPrice = 5 },
            new PizzasModel(){ImageTitle="Pepperoni" ,
                PizzaName = "Pepperoni", BasePrice = 2,
                TomatoSauce=true ,
                Pepperoni=true,
                Cheese=true ,
                FinalPrice = 5 }
            
        };
        public void OnGet()
        {
        }
    }
}
