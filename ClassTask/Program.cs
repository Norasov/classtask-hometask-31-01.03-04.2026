


// using Domain.Models.ClassTask;
// Circle circle = new Circle(5.3, "red", true);
// System.Console.WriteLine("Радиус круга: "+circle.GetRadius());
// System.Console.WriteLine("Площадь круга: "+circle.GetArea());
// System.Console.WriteLine("Периметр круга: "+circle.GetPerimeter());
// System.Console.WriteLine();
// System.Console.WriteLine(circle.ToString());
// System.Console.WriteLine();

// Rectangle rectangle = new Rectangle(7,12,"green", false);
// System.Console.WriteLine("Длина прямоугольника: "+rectangle.GetWidth());
// System.Console.WriteLine("Ширина прямоугольника: "+rectangle.GetLength());
// System.Console.WriteLine("Площадь прямоугольника: "+rectangle.GetArea());
// System.Console.WriteLine("Периметер прямугольника: "+rectangle.GetPerimeter());
// System.Console.WriteLine();
// System.Console.WriteLine(rectangle.ToString());
// System.Console.WriteLine();

// Square square = new Square(13, "Blue", true);
// System.Console.WriteLine("Площадь квадрата: "+square.GetArea());
// System.Console.WriteLine("Периметр квадрата: "+square.GetPerimeter());
// System.Console.WriteLine();
// System.Console.WriteLine(square.ToString());


//-------------------------------------HOMETASK---------------------------
using Domain.Models.HomeTask;
Circle circle = new Circle(4.3);
System.Console.WriteLine("Площадь круга: "+circle.GetArea());
System.Console.WriteLine("Периметр круга: "+circle.GetPerimeter());
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine();

ResizableCircle resizableCircle = new ResizableCircle(7.1);
System.Console.WriteLine("Площадь круга: "+resizableCircle.GetArea());
System.Console.WriteLine("Периметр круга: "+resizableCircle.GetPerimeter());
System.Console.WriteLine();
resizableCircle.Resize(25);
System.Console.WriteLine("Измененная площадь круга: "+resizableCircle.GetArea());
System.Console.WriteLine("Измененный периметер круга: "+resizableCircle.GetPerimeter());
System.Console.WriteLine(resizableCircle.ToString());