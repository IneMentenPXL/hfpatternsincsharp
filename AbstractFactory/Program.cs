using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PortlandPizzaStore();
            store.OrderPizza("Cheese");
            store = new HillsboroPizzaStore();
            store.OrderPizza("Clam");
            Console.ReadLine();
        }
    }
}
