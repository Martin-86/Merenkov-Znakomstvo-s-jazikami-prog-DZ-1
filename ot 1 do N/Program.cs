Console.WriteLine("введите число");
int X = Convert.ToInt32(Console.ReadLine());

int[] arr = Enumerable.Range(1, X).ToArray();

if (X > 1)
{
    int n = arr.Length;

    int index = 0;

    while (index < n)
    {
        if (arr[index] % 2 == 0)
        {
            Console.WriteLine(arr[index]);    
        }
        index++;
    }
}
else
{
    Console.WriteLine("Нет четных чисел");
}

// void PrintArray(int[] arr)    
// {
//     int count = arr.Length; 
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(arr[position]);
//         position++;
//     }
// }



// PrintArray(arr);

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     //index= index+1;
//     index++;
// }

// Console.WriteLine("введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= n; i += 1)
//     if (i % 2 == 0)
//     {
//         Console.WriteLine($"Ответ {i}");
//     }
