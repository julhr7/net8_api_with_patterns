﻿namespace Strategies
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }
}
