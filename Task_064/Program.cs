Console.WriteLine("введите максимальное значение интервала N ");
int N = int.Parse(Console.ReadLine());
void RecursionNumbers (int i)
{
    if (i == 1)
    {
        Console.Write(i + ", ");
    }
    else
    {
        Console.Write(i + ", ");
        i--;
        RecursionNumbers(i);
    }
}

RecursionNumbers(N);
