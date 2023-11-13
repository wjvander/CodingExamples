namespace CodingExamples._2._O_refactored;

interface IDiscount
{
    double Calculate();
}

class RegularDiscount : IDiscount
{
    public double Calculate()
    {
        return 0.10; // 10% discount
    }
}

class PremiumDiscount : IDiscount
{
    public double Calculate()
    {
        return 0.20; // 20% discount
    }
}

class DiscountCalculator
{
    public double CalculateDiscount(IDiscount discount)
    {
        return discount.Calculate();
    }
}