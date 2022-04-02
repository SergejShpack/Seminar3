
             //Написать программу вычисления произведения чисел от 1 до N"

Console.Write("Введите число: N = ");
int N = int.Parse(Console.ReadLine());

int number = 1;
int factorial = 1;
    while (number <= N)
{
    factorial = factorial * number;
    number++;
}
Console.Write("Произведение чисел от 1 до N равно " + factorial);