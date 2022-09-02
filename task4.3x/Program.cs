//Назовём число «интересным» если его произведение цифр делится на их сумму. 
//Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
//(Каждый эл-т массива должен быть сгенерирован случайно)
Random rand = new Random();
Console.WriteLine("Сколько интересных чисел тебе показать? Введи число:");
int n = Convert.ToInt32(Console.ReadLine()); // число n
int last_digit;  // последняя цифра числа
int i = 0; // счетчик
int y; // произведение / сумма

int [] nums = new int [n];  // создать массив на n- чисел

while (i < n)
{
    int x = rand.Next(101); // x - претендент на интересность, ограничен 0-100
    Console.WriteLine("Претендент: " + x);
    int tmp = x;  // временный x
    int product = 1;  // произведение цифр
    int total = 0;  // сумма цифр
    while (tmp > 0)
    {
    last_digit = tmp % 10;
    //Console.WriteLine(last_digit);
    total += last_digit;
    Console.WriteLine("Сумма: " + total);
    product *= last_digit;
    Console.WriteLine("Произведение: " + product);
    tmp /= 10;
    }

    y = product % total;
    Console.WriteLine("Остаток от деления: " + y);
    if ( y == 0)
        {
           nums[i] = x; 
        }
    else
    {
        continue;
    }
    i++;
}
Console.WriteLine(string.Join(",", nums)); // вывод массива


