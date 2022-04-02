//     Найти кубы чисел от 1 до N

Console.WriteLine(" Найти кубы чисел от 1 до N");


Console.Write("Введите N (от 1 до 255): ");
byte N = Convert.ToByte(Console.ReadLine());


     for (int i = 1; i <= N; ++i)
{
    string text = " \n";
    text = text + "   " + i + " \t| " + i * i * i;
    Console.WriteLine(text);
}
