using System;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Standard baking technique.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Standard cutting technique.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Standard boxing technique.");
        }
    }
}
