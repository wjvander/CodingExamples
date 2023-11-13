namespace CodingExamples._3._L;


public abstract class Bird
{
}

public class AquaticBird : Bird
{
    public virtual void Swim()
    {
        // Implementation for birds swimming in water
    }
}

public class Penguin : AquaticBird
{
    // Penguins can swim but can't fly
}

public class Duck : AquaticBird
{
    public override void Swim()
    {
        // Ducks can swim and also fly
    }

    public void Fly()
    {
        // Implementation for duck flying
    }
}