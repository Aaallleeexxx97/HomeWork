using System;

class Program
{
    static void Main() {
        int a,b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        if(a > b)
            {
                Console.WriteLine($"Число {a} больше числа {b}");
            }
        else
            {
               Console.WriteLine($"Число {b} больше числа {a}"); 
            }
    }
}