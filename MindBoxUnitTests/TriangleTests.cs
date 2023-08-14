using MindBoxLibrary;

namespace MindBoxUnitTests;

public class TriangleTests
{
    [Fact]
    public void TriangleManyValues()
    {
        //Arrange act
        try
        {
            IFigure triangel = new Triangle(12, 12, 12, 12, 12);
        }
        catch (Exception e)
        {
            //Assert
            Assert.Equal("неверное количество аргументов",e.Message);
        }
    }

    [Fact]
    public void TriangleNoValues()
    {
        //Arrange act
        try
        {
            IFigure triangel = new Triangle();
        }
        catch (Exception e)
        {
            //Assert
            Assert.Equal("неверное количество аргументов",e.Message);
        }
    }

    [Fact]
    public void TriangleWrongSides()
    {
        //Arrange act
        try
        {
            IFigure triangel = new Triangle(1,1,2);
        }
        catch (Exception e)
        {
            //Assert
            Assert.Equal("такого треугольника не существует",e.Message);
        }
    }

    [Fact]
    public void NegativeSideValue()
    {
        //Arrange Act
        try
        {
            IFigure triangel = new Triangle(-1,-1,2);
        }
        catch (Exception e)
        {
            //Assert
            Assert.Equal("неверные аргументы",e.Message);
        }

    }

    [Fact]
    public void CalculateVSquare()
    {
        //Arrange
        IFigure triangle = new Triangle(3,4,5);
        Calculator calculator = new Calculator();

        //Act

        var response = calculator.CalculateSquare(triangle);

        //Assert

        Assert.Equal(response,6);
        
        
    }
}