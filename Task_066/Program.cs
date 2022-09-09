Console.WriteLine("введите минимальное значение интервала m ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("введите максимальное значение интервала n ");
int n = int.Parse(Console.ReadLine());

 int SumNumbers(int n, int m)
 {
    if (m == 0) return (n * (n + 1)) / 2;            // Если M равно нулю
    else if (m == n) return m;                       // Если M=N
    else if (m < n) return n + SumNumbers(m, n - 1); // Если M<N
    else return n + SumNumbers(m, n + 1);            // Если M>N
 }   
 Console.Write($"Сумма натуральных чисел от {m} до {n} равна {SumNumbers(n, m)}");