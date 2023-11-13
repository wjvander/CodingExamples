namespace CodingExamples._2._O_refactored;

interface ICoffee
{
    void Make();
}

class Espresso : ICoffee
{
    public void Make()
    {
        Console.WriteLine("Making an espresso...");
    }
}

class Cappuccino : ICoffee
{
    public void Make()
    {
        Console.WriteLine("Making a cappuccino...");
    }
}

class CoffeeMachine
{
    public void MakeCoffee(ICoffee coffee)
    {
        coffee.Make();
    }
}