namespace Strategies
{
    public class HalfDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.5m;
        }
    }
}
