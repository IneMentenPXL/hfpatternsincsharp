using System;

namespace AbstractFactory
{
    class CheesePizza : Pizza
    {
        private readonly IIngredientFactory _ingredientFactory;

        public CheesePizza(IIngredientFactory customIngredientFactory)
        {
            _ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _ingredientFactory.CreateDough();
            _ingredientFactory.CreateSauce();
            _ingredientFactory.CreateCheese();
        }
    }

    class ClamPizza : Pizza
    {
        private readonly IIngredientFactory _ingredientFactory;

        public ClamPizza(IIngredientFactory customIngredientFactory)
        {
            _ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _ingredientFactory.CreateDough();
            _ingredientFactory.CreateSauce();
            _ingredientFactory.CreateCheese();
        }
    }

    class ShoePizza : Pizza
    {
        private readonly IIngredientFactory _ingredientFactory;

        public ShoePizza(IIngredientFactory customIngredientFactory)
        {
            _ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _ingredientFactory.CreateDough();
            _ingredientFactory.CreateSauce();
            _ingredientFactory.CreateCheese();
        }
    }
}
