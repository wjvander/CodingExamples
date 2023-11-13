namespace CodingExamples._2._O_violation;

class DiscountCalculator
{
    public double CalculateDiscount(string userType)
    {
        if(userType == "Regular")
        {
            return 0.10; // 10% discount
        }
        else if(userType == "Premium")
        {
            return 0.20; // 20% discount
        }
        return 0;
    }
}
