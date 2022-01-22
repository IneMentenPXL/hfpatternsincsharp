namespace Decorator
{
    public class AfricanBlend : Beverage
    {
        public AfricanBlend()
        {
            description = "AfricanBlend";
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }
}
