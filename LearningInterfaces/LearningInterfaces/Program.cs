using LearningInterfaces.Concrete;
using System.Net;

Rectangle rectangle = new Rectangle();


rectangle.SideA = 5;
rectangle.SideB = 10;

decimal rectangleArea = rectangle.CalculateArea();

Console.WriteLine(rectangleArea);


Circle circle = new Circle();

circle.Radius = 10;

decimal circleArea  = circle.CalculateArea();   

Console.WriteLine(circleArea);

decimal rectanglePerimeter = rectangle.CalculatePerimeter();

Console.WriteLine(rectanglePerimeter);

decimal circlePerimeter = circle.CalculatePerimeter();

Console.WriteLine(circlePerimeter);


