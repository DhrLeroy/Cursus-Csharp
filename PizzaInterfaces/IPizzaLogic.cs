using PizzaKlassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaInterfaces
{
    public interface IPizzaLogic
    {
        bool BestaatPizzaMetId(int id);
        IList<Pizza> GeefAllePizzas();
        Pizza GeefPizzaById(int? id);
        void UpdatePizza(Pizza pizza);
        void VerwijderPizza(Pizza pizza);
        void VoegPizzaToe(Pizza pizza);
    }
}
