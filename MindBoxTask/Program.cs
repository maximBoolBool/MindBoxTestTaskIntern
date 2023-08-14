

using MindBoxLibrary;

//Arrange
IFigure triangle = new Triangle(3,4,5);
Calculator calculator = new Calculator();

//Act

var response = calculator.CalculateSquare(triangle);

Console.WriteLine(response);