//Назовём число «интересным» если его произведение цифр делится на их сумму. 
//Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
//(Каждый эл-т массива должен быть сгенерирован случайно)
Random rand = new Random();
Console.WriteLine("Сколько интересных числе тебе показать? Введи число:");
int n = Convert.ToInt32(Console.ReadLine()); // 
int product = 1;
int total = 0;
int last_digit;

// Console.WriteLine(x);
int [] nums = new int [n];

int x = rand.Next(101);
int tmp = x;
while (x < 0)
{
    last_digit = tmp % 10;
    if (last_digit != 0 && x % last_digit == 0)
        {
            count += last_digit;
        }
    tmp /= 10;
    product *= A;
    i++;
}
if ()
nums[i] = x