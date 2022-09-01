//  Напишите программу, которая принимает на вход число и выдаёт сумму 
//цифр в числе, которые являются делителями этого числа. 
//(для получения цифр числа операцию приведения числа к строке не использовать)
Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
int tmp = 0;
int count = 0;
int last_digit;
while (tmp > 0)
{
    last_digit = tmp % 10;
    if (x % last_digit == 0)
    {
        count += last_digit;
    }
    tmp /= 10;
}
Console.WriteLine(count);