using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace starting_app.Pages
{
  public class PizzaModel : PageModel
  {
    public double PizzaTotal (string pizzaType)
    {
      Dictionary<string, double> PizzaCost = new Dictionary<string, double>()
      {
        { "Cheese", 10 },
        { "Pepperoni", 11 },
        { "Vegetarian", 12 },
      };
      
      return PizzaCost[pizzaType];
    }

    public double Total {get; set;}
    public string Customer {get; set;}
    public string Order {get; set;}
    public bool ExtraCheese {get; set;}

    public void OnGet()
    // declare these on render to be the initial state
    {
    Customer = "nick";
    Order = "Cheese";
    ExtraCheese = false;
    Total = PizzaTotal("Cheese");
    }
  }
}
