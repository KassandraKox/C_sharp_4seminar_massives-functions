// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Не использовать 
// функцию Math.Pow()
Console.WriteLine("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int product = 1;
while (i < B)
{
    product *= A;
    i++;
}
Console.WriteLine("Число " + A + " в степени " + B + " равно " + product);