// Задать значения M и N.
// Найти сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите через пробел значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите через пробел значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int firstNum = 0;
int secondNum = 0;
if (m < n)
{
    firstNum = m;
    secondNum = n;
}
else
{
    firstNum = n;
    secondNum = m;
}

int GetSumRecursively(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return secondNum; 
    return firstNum + GetSumRecursively(firstNum+1, secondNum);
}

int result = GetSumRecursively(firstNum, secondNum);
Console.WriteLine(result);