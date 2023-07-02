// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
// Значения b1, k1, b2 и k2 задаются пользователем.

// Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    System.Console.Write("Введите через пробел в указанном порядке b1, k1, b2 и k2: ");
    double[] array = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
    XY(array, out double X, out double Y);
    System.Console.WriteLine($"Координата пересечения: X {X}");
    System.Console.WriteLine($"Координата пересечения: Y {Y}");
}

Main();

void XY(double[] array, out double X, out double Y)
{
    X = (array[2] - array[0]) / (array[1] - array[3]);
    Y = array[1] * X + array[0];
}