public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Greet()
    {
        System.Console.WriteLine("Hello!"); 
    }
    public void SetAge(int age)
    {
        Age = age;
    }
}