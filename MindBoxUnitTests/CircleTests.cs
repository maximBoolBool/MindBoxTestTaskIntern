using MindBoxLibrary;

namespace MindBoxUnitTests;

public class UnitTest1
{
    [Fact]
    public void NegativeCircleValueTest()
    {
        //Arrage
        
        //Act Assert
        try
        {
            IFigure figure = new Circle(-1);

        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Переданно неверное значение");
        }
    }

    [Fact]
    public void ManyValuesValuesCircleTest()
    {
        try
        {
            IFigure figure = new Circle(12,312,423,234,123);

        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Неверное кол. аргументов");
        }
    }
    
    [Fact]
    public void CalculateCircleAreaTest()
    {
        //Arrage
        IFigure circle = new Circle(1);
        Calculator calculator = new Calculator();
        
        //Act
        var response =calculator.CalculateSquare(circle);
        
        //Assert
        Assert.Equal(response,Math.PI);
    }

    [Fact]
    public void NoValuesCircleTest()
    {
        //Arrange Act
        try
        {
            IFigure figure = new Circle();
        }
        catch (Exception e)
        {
            //Assert
            Assert.Equal(e.Message,"Неверное кол. аргументов");
        }
    }
    
}