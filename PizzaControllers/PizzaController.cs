using PizzaInterfaces;
using PizzaKlassen;
using PizzaRestaurantData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaControllers
{
    public class PizzaController : IPizzaLogic
    {
        private IPizzaData pizzaData;

        public PizzaController(IPizzaData pizzaData)
        {
            this.pizzaData = pizzaData;
        }

        public bool BestaatPizzaMetId(int id)
        {
            return pizzaData.BestaatPizzaMetId(id);
        }

        public IList<Pizza> GeefAllePizzas()
        {
            return pizzaData.GeefAllePizzas();
        }

        public Pizza GeefPizzaById(int? id)
        {
            return pizzaData.GeefPizzaById(id);
        }

        public void UpdatePizza(Pizza pizza)
        {
            pizzaData.UpdatePizza(pizza);
        }

        public void VerwijderPizza(Pizza pizza)
        {
            pizzaData.VerwijderPizza(pizza);
        }

        public void VoegPizzaToe(Pizza pizza)
        {
            pizzaData.VoegPizzaToe(pizza);
        }
    }
}
