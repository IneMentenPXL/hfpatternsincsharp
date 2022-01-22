using System;

namespace AbstractFactory
{
    public interface IIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
    }

    public class Dough
    {
    }

    public class Sauce
    {
    }

    public class Cheese
    {
    }

    public class PortlandIngredientFactory : IIngredientFactory
    {
        #region IngredientFactory Members

        public Dough CreateDough()
        {
            Console.WriteLine("Portland dough");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Portland sauce");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Portland cheese");
            return new Cheese();
        }

        #endregion
    }

    public class HillsboroIngredientFactory : IIngredientFactory
    {
        #region IngredientFactory Members

        public Dough CreateDough()
        {
            Console.WriteLine("Hillsboro dough");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Hillsboro sauce");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Hillsboro cheese");
            return new Cheese();
        }

        #endregion
    }

}
