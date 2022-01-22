namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage newBeverage)
        {
            Beverage = newBeverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy " + GetCost();
        }

        public override double GetCost()
        {
            double cost = Beverage.GetCost();
            if (Beverage.GetSize() == Size.Tall)
            {
                cost += .10;
            }
            else if (Beverage.GetSize() == Size.Grande)
            {
                cost += .15;
            }
            else if (Beverage.GetSize() == Size.Venti)
            {
                cost += .20;
            }

            return cost;
        }
    }
}
