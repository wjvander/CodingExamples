namespace CodingExamples._3._L;

public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        // Start a car engine
        Console.WriteLine("BROOOOOM! Takatakataka VROOM");
    }

    public override void StopEngine()
    {
        // Stop a car engine
        Console.WriteLine("Takatakataaa");
    }
}

public class ElectricCar : Vehicle
{
    public override void StartEngine()
    {
        throw new NotImplementedException("Electric cars do not have engines in the traditional sense.");
    }

    public override void StopEngine()
    {
        throw new NotImplementedException("Electric cars do not have engines in the traditional sense.");
    }
}