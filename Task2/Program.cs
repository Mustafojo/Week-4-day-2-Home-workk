var location1 = new Location(10,20);
var location2 = new Location(100,200);

var rec = new Rectengle("Red",10,20,location1);
System.Console.WriteLine("Rectengle : ");
System.Console.WriteLine("Width = " + rec.GetWidth());
System.Console.WriteLine("Length = " + rec.GetLength());
System.Console.Write("ToString : ");
System.Console.WriteLine(rec.ToString());
System.Console.Write("Perimeter : ");
System.Console.WriteLine(rec.GetPerimeter());
System.Console.Write("Area : ");
System.Console.WriteLine(rec.GetArea());
System.Console.Write("Location of X = ");
System.Console.WriteLine(location1.GetX());
System.Console.Write("Location of Y = ");
System.Console.WriteLine(location1.GetY());
System.Console.WriteLine("---------------------------------");


var circle = new Circle("Black",10,location2);
System.Console.WriteLine("Circle : ");
System.Console.WriteLine("Radius = " + circle.GetRadius());
System.Console.Write("ToString : ");
System.Console.WriteLine(circle.ToString());
System.Console.Write("Area : ");
System.Console.WriteLine(circle.GetArea());
System.Console.Write("Perimeter : ");
System.Console.WriteLine(circle.GetPerimeter());
System.Console.Write("Location of X = ");
System.Console.WriteLine(location2.GetX());
System.Console.Write("Location of Y = ");
System.Console.WriteLine(location2.GetY());