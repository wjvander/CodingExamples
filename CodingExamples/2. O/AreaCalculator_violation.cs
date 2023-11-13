namespace CodingExamples._2._O_violation;

class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

class Circle
{
    public double Radius { get; set; }
}

class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle)
        {
            Rectangle rectangle = (Rectangle)shape;
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle)
        {
            Circle circle = (Circle)shape;
            return circle.Radius * circle.Radius * Math.PI;
        }
        return 0;
    }
}