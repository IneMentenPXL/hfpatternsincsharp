namespace Decorator
{
    public abstract class Beverage
    {
        public enum Size
        {
            Tall,
            Grande,
            Venti
        }

        public string description = "Unknown Beverage";
        public Size size;

        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public Size GetSize()
        {
            return size;
        }

        public abstract double GetCost();
    }
}
