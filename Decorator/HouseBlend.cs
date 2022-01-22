namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double GetCost()
        {
            return 0.89;
        }
    }
}
