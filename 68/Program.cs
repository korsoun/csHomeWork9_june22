// Вычислить рекурсивно функцию Акермана A(m, n). Числа m и n неотрицательные.


// при m>0 и n>0    = A(m-1, A(m, n-1))
// при m>0 и n=0    = A(m-1, 1)
// при m=0          = n+1

int Ackermann(int m, int n)
{
    int functionResult = 0;
    if (m == 0) functionResult = n + 1;
    if (m > 0 && n == 0) functionResult = Ackermann(m - 1, 1);
    if (m > 0 && n > 0) functionResult = Ackermann(m - 1, Ackermann(m, n - 1));
    return functionResult;
}

Console.WriteLine("Введите число M: ");
int mValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int nValue = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(mValue, nValue);
Console.WriteLine(result);


