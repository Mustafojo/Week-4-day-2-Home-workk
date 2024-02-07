public class Rectengle : Shape
{
    protected double length;
    protected double width;
    public Rectengle(string color,double length,double width,Location c):base(color,c)
    {
        this.length = length;
        this.width = width;
    }
    public string ToString()
    {
        return $"The color of Rectengle is {GetColor()}";
    }
    public double GetLength()
    {
        return length;
    }
    public double GetWidth()
    {
        return width;
    }
    public double GetArea()
    {
        return width + length;
    }
    public double GetPerimeter()
    {
        return 2 * (width * length);
    }
}