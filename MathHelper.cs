using System.Security.Cryptography;
using System.Drawing;

namespace MathLibrary;

public class MathHelper
{
    //Вычисление площади круга по радиусу
    public static double CalcAreaCircle(double radius)
    {
        return Math.PI * radius * radius;
    }

    //Вычисление площади треугольника по трем вершинам
    public static double CalcAreaTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        return 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
    }

    //Вычисление площади фигуры с неизвестным количеством вершин
    public static double calcAreaPoly(Point[] polygon)
    {
        double area = 0;
        for (int i = 0; i < polygon.Length; i++)
        {
            int j = (i + 1) % polygon.Length;
            Point a = polygon[i], b = polygon[j];
 
            area += a.X * b.Y - a.Y * b.X;
        }
        return Math.Abs(area) / 2;
    }

    //Проверка, является ли треугольник прямоугольным
    public static bool isRightTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double[] lengths = new double[3];
        lengths[0] = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2));
        lengths[1] = Math.Sqrt(Math.Pow((x3 - x2), 2)+Math.Pow((y3 - y2), 2));
        lengths[2] = Math.Sqrt(Math.Pow((x1 - x3), 2)+Math.Pow((y1 - y3), 2));
        Array.Sort(lengths);
        if (Math.Pow(lengths[2], 2) == Math.Pow(lengths[1], 2) + Math.Pow(lengths[0], 2))
            return true;
        else
            return false;
    }
}