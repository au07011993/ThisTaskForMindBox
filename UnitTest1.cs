using MathLibrary;
using System.Drawing;
namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    //Проводим тест на корректное вычисление площади окружности
    public void CalculateAreaCircle()
    {
        var actualResult = Math.Round(MathLibrary.MathHelper.CalcAreaCircle(5),1);
        var expectedResult = 78.5;
        
        Assert.AreEqual(expectedResult,actualResult);
    }
    
    
    [Test]
    //Проводим тест на корректное вычисление площади треугольника
    public void CalculateAreaTriangle()
    {
        var actualResult = MathLibrary.MathHelper.CalcAreaTriangle(1, 1, 1, 3, 3, 1);
        var expectedResult = 2;
        
        Assert.AreEqual(expectedResult,actualResult);
    }
    
    [Test]
    //Проводим тест прямоугольный ли треугольник
    public void CalculateRightTriangle()
    {
        var actualResult = MathLibrary.MathHelper.isRightTriangle(1, 1, 1, 4, 5, 1);
        var expectedResult = true;
        
        Assert.AreEqual(expectedResult,actualResult);
    }
    
    [Test]
    //Проводим тест на корректное вычисление площади фигуры заранее неузвестную
    public void CalculateAreaPolygon()
    {
        var actualResult = MathLibrary.MathHelper.calcAreaPoly(new Point[]
        {
            new Point{X=0,Y=0},
            new Point{X=0,Y=3},
            new Point{X=2,Y=5},
            new Point{X=4,Y=4},
            new Point{X=4,Y=1}
        });
        var expectedResult = 15d;
        
        Assert.AreEqual(expectedResult,actualResult);
    }
}