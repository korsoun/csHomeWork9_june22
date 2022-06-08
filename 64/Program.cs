// Задать N.
// Вывести с помощью рекурсии натуральные числа от N до 1.

void GetNumberRowRecursively(int n, int N)
{
    
    if (n == 0) return;

    GetNumberRowRecursively(n - 1, N);
    Console.Write($"{(N+1)-n} ");
}

Console.WriteLine("Задайте число N: ");
int n =  Convert.ToInt32(Console.ReadLine());
int N = n;
GetNumberRowRecursively(n, N);
