namespace Decorator
{
    public class Cream : CondimentDecorator
    {
        public Cream(Beverage newBeverage)
        {
            Beverage = newBeverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Cream " + GetCost();
        }

        public override double GetCost()
        {
            return Beverage.GetCost() + 0.15;
        }
    }
}
