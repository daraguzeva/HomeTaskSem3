//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] Pal = new int[5];
if (num / 100000 == 0)
{
    Pal[0] = num / 10000;
    int a = num / 1000;
    int b = a % 10;
    Pal[1] = b;
    int c = num / 100;
    int d = c % 10;
    Pal[2] = d;
    int f = num / 10;
    int j = f % 10;
    Pal[3] = j;
    Pal[4] = num % 10;
    if (Pal[0] == Pal[4])
    {
        if (Pal[1] == Pal[3])
        {
            Console.Write("Число является палиндромом.");
        }
    }
    else
    {
        Console.Write("Число не является палиндромом.");
    }
}
else
{
    Console.Write("Число не пятизначное. Введите пятизначное число.");
}