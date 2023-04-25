// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int M = Num("M");
int N = Num("N");

int Summ(int M, int N)
{
    int sum = 0;
    for (int i = M; i <= N; i++)
    {
        sum = sum + i;
    }
return sum;
}

System.Console.WriteLine(Summ(M, N));