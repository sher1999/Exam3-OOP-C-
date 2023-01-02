using MainApp;

Console.WriteLine("Circle:");
var circle = new Circle(3, "Black", true);
Console.WriteLine("Area: " + circle.GetArea());
Console.WriteLine("Perimeter: " + circle.GetPerimeter());
Console.WriteLine(circle.ToString());

Console.WriteLine();
Console.WriteLine("Rectangle:");
var rectangle = new Rectangle(2, 3, "White", false);
Console.WriteLine("Area: " + rectangle.GetArea());
Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
Console.WriteLine(rectangle.ToString());

Console.WriteLine();
Console.WriteLine("Square:");
var square = new Square(3, "Green", true);
square.SetWidth(2);
square.SetLength(2);
Console.WriteLine("Side: "+square.GetSide());
Console.WriteLine(square.ToString());