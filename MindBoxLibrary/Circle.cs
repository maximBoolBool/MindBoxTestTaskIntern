namespace MindBoxLibrary;

public class Circle : IFigure
{
    private double Radius { get; set; }


    public Circle(params double[] args)
    {
        if (args.Length != 1)
            throw new Exception("Неверное кол. аргументов");

        if (args[0] <= 0)
            throw new Exception("Переданно неверное значение");
        Radius = args[0];
    }

    public double GetSquare()
    {
        
        return Math.PI * Math.Pow(Radius, 2);

    }
}