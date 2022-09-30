// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
void InputNumbers(int N, int M, int sum)
{
    if (M > N)
    {

        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;

    }
    sum = sum + (M++);
    InputNumbers( N,  M, sum);
}
 InputNumbers( N, M, 0);

