public class Shape
{
    protected string color;
    protected Location c;
    public Shape(string color,Location c)
    {
        this.color = color;
        this.c = c;
    }
    public string GetColor()
    {
        return color;
    }
    public string ToString()
    {
        return "Rangi figuraro dar bachahoyash muayyan kuned";
    }
}