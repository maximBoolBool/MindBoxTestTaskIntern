namespace MindBoxLibrary;

public class Triangle  : IFigure
{

  private double bigеstSide;
  private double firstSmallSide;
  private double secondSmallSide;
  
  public Triangle(params double[] args  )
  {
    if (args.Length != 3)
      throw new Exception("неверное количество аргументов");
    Array.Sort(args);
    
    if(args[2]  <= 0 )
      throw new Exception("неверные аргументы");
    
    bigеstSide = args[2];
    firstSmallSide = args[1];
    secondSmallSide = args[0];

    if (!IsDataValid())
      throw new Exception("такого треугольника не существует");
  }


  public double GetSquare()
  {
    var halfPerimetr = bigеstSide + firstSmallSide + secondSmallSide;
    return Math.Sqrt(halfPerimetr*(halfPerimetr-bigеstSide)*(halfPerimetr-firstSmallSide)*(halfPerimetr-secondSmallSide));
  }

  public bool IsTriangleHasReactAngular()
  {
    return (Math.Pow(bigеstSide,2) == Math.Pow(firstSmallSide,2) + Math.Pow(secondSmallSide,2) ) ;
  }


  private bool IsDataValid()
  {
    return (bigеstSide < secondSmallSide + firstSmallSide);
  }
  
  
}