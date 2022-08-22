Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(1<=num)
{
    sum = sum + (num%10);
    num = num/10;        
}
Console.Write($"Сумма цифр, составляющих число, равна {sum}.");


