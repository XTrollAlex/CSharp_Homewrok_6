// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void Main()
{
    System.Console.Write("Введите массив чисел с клавиатуры: ");
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    PositiveNumbers(array, out int N);
    Console.WriteLine($"Чисел в массиве больше '0' :{N}");
}

Main();

int PositiveNumbers(int[] array, out int N)
{
    N = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            N++;
        }
    }
    return N;
}