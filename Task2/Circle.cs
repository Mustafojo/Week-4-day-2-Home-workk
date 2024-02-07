public class Circle : Shape 
{
    protected double radius;
    public Circle(string color,double radius,Location c) : base(color,c)
    {
        this.radius = radius;
    }
    public string ToString()
    {
        return $"The color of Circle is {GetColor()}";
    }
    public double GetRadius()
    {
        return radius;
    }
    public double GetArea()
    {
        return radius * radius * 3.14;
    }
    public double GetPerimeter()
    {
        return 2 * 3.14 * radius;  
    }
    
}