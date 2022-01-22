namespace AbstractFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);

            pizza.Prepare(); // abstract factory pattern
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }

    public class PortlandPizzaStore : PizzaStore
    {
        // portland-style preparation for all pizzas
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory =
                new PortlandIngredientFactory();

            if (type == "Cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Portland style cheese Pizza";
            }
            else if (type == "Clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Portland style clam Pizza";
            }
            else if (type == "Suede")
            {
                pizza = new ShoePizza(ingredientFactory);
                pizza.Name = "Portland style suede Pizza";
            }

            return pizza;
        }
    }
    
    public class HillsboroPizzaStore : PizzaStore
    {
        // portland-style preparation for all pizzas
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory =
                new HillsboroIngredientFactory();

            if (type == "Cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Portland style cheese Pizza";
            }
            else if (type == "Clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Portland style clam Pizza";
            }
            else if (type == "Suede")
            {
                pizza = new ShoePizza(ingredientFactory);
                pizza.Name = "Portland style suede Pizza";
            }

            return pizza;
        }
    }
}
