using System;
using System.IO;

namespace Decorator
{
    internal class UpperCaseTextReader
    {
        private readonly TextReader myTextReader;

        private UpperCaseTextReader(TextReader newTextReader)
        {
            myTextReader = newTextReader;
        }

        public string ReadToEnd()
        {
            return myTextReader.ReadToEnd().ToUpper();

            // example
            //UpperCaseTextReader reader =
            //    new UpperCaseTextReader(new TextReader(
            //        new FileStream(path)));
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Beverage bev = new AfricanBlend();
            Console.WriteLine("{0} - ${1}", bev.GetDescription(), bev.GetCost());

            bev = new HouseBlend();
            bev.SetSize(Beverage.Size.Venti);
            Console.WriteLine("{0} - ${1}", bev.GetDescription(), bev.GetCost());

            bev = new Cream(bev);
            Console.WriteLine("{0} - ${1}", bev.GetDescription(), bev.GetCost());

            bev = new Soy(bev);
            Console.WriteLine("{0} - ${1}", bev.GetDescription(), bev.GetCost());
            Console.ReadLine();
        }
    }
}
