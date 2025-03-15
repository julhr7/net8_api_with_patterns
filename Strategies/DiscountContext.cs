namespace Strategies
{
    public class DiscountContext
    {
        private IDiscountStrategy _strategy;

        public DiscountContext(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return _strategy.ApplyDiscount(price);
        }
    }
}
