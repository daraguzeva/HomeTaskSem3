// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    int A = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"{i}^3 = {A}");
}
Console.WriteLine();

