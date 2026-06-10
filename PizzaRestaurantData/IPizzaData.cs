using PizzaKlassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaRestaurantData
{
    public interface IPizzaData
    {
        bool BestaatPizzaMetId(int id);
        IList<Pizza> GeefAllePizzas();
        Pizza GeefPizzaById(int? id);
        void UpdatePizza(Pizza pizza);
        void VerwijderPizza(Pizza pizza);
        void VoegPizzaToe(Pizza pizza);
    }
}
