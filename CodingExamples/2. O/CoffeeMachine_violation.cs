namespace CodingExamples._2._O_violation;

public class CoffeeMachineViolation
{
    public void MakeCoffee(string type)
    {
        if(type == "espresso")
        {
            Console.WriteLine("Making an espresso...");
        }
        else if(type == "cappuccino")
        {
            Console.WriteLine("Making a cappuccino...");
        }
    }
}