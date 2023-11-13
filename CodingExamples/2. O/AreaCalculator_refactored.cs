namespace CodingExamples._2._O_refactored;

interface IShape
{
    double CalculateArea();
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }
}

class AreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}
