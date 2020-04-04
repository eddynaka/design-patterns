namespace Exercises.Stocks
{
    public class Investor : IInvestor
    {
        private string name;
        private Stock stock;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            System.Console.WriteLine("Notified {0} of {1}'s changed to {2:C}", name, stock.Symbol, stock.Price);
        }

        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}