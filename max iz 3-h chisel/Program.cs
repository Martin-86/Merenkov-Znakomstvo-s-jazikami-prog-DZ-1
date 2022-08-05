Console.WriteLine("введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

int a = number1;
int b = number2;
int c = number3;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;


Console.Write("max = ");
Console.Write(max);