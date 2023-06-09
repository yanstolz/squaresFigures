using FigureLib;

Circle circle = new Circle(5);
Console.WriteLine($"Площадь круга с радиусом 5: {circle.GetArea()}");

Triangle triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Площадь треугольника со сторонами 3, 4 и 5: {triangle.GetArea()}");


Console.WriteLine($"Треугольник со сторонами 3, 4 и 5 является прямоугольным: {triangle.IsRightAngled()}");
