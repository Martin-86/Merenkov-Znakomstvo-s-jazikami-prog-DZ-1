Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= n; i += 1)
    if (i % 2 == 0)
    {
        Console.WriteLine($"Ответ {i}");
    }
