Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(number1);
    Console.Write(" четное");
}
else
{
    Console.Write("Число ");
    Console.Write(number1);
    Console.Write(" нечетное");
}



