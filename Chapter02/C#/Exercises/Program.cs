using System;
using Exercises.Stocks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var msft = new MicrosoftStock("MSFT", 140.00);
            msft.Attach(new Investor("Sorros"));
            msft.Attach(new Investor("Berkshire"));

            msft.Price = 120.10;
            msft.Price = 121.00;
            msft.Price = 120.50;
            msft.Price = 120.75;
        }
    }
}
