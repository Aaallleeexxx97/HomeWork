using System;

class Program
{
    static void Main()
    {
        // int a = Convert.ToInt32(Console.ReadLine());
        // int b = Convert.ToInt32(Console.ReadLine());
        // int[,] mass = new int[a, b];
        // int x = 0;
        // for (int i = 0; i < a; i++)
        // {
        //     for (int j = 0; j < b; j++)
        //     {
        //         mass[i, j] = new Random().Next(100, 1000);
        //         Console.Write(mass[i, j] + " ");
        //         if (mass[i, j] % 2 == 0)
        //         {
        //             x++;
        //         }
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine(x);

        int a = Convert.ToInt32(Console.ReadLine());
        int [] array = new int [a];
        int summ = 0;
        for (int i = 0; i < a; i++)
        {
            array[i] = new Random() .Next(1,50);
            Console.Write(array[i] + " ");
            if (i % 2 == 0)
            {
                summ = summ + array [i];
            }
            Console.WriteLine();
        }
        Console.WriteLine(summ);
    }
}   
