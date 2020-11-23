using System.Collections.Generic;

namespace Exercises.Stocks
{
    public abstract class Stock
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return symbol; }
        }
    }
}