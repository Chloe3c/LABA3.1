Console.WriteLine("Введите верхнюю границу N:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Нечетные кратные пяти числа от 10 до " + N + ":");
for (int i = 10; i <= N; i++)
{
    if (i % 5 == 0)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}