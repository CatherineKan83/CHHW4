Console.Write("Введите число: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write($"Для возведения {A} в степень, введние натуральное число: ");
double B = Convert.ToInt32(Console.ReadLine());
if(B>0)
{
    Console.WriteLine($"{A}^{B} = {Math.Pow(A, B)}");
}
else Console.WriteLine("Ошибка ввода");