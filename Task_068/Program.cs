Console.WriteLine("введите первое целое неотрицательное число m ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе целое неотрицательное число n ");
int n = int.Parse(Console.ReadLine());

 int Akkerman(int n, int m)
 {
    if (m == 0) return (n + 1);           
    else if (n == 0 && m != 0) return Akkerman(m - 1, 1); 
    else if (n > 0 && m > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return Akkerman(n, m);
 }
 
 Console.Write($"Функция Аккермана для неотрицательных чисел {m} и {n} равна {Akkerman(n, m)}");
