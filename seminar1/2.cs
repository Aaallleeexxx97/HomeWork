using System;

class Program
{
    static  void Main() {
        int a,b,c;
        a = 2;
        b = 3;
        c = 7;
        if(a>b && a>c)
        {
            Console.WriteLine(a);
            
        }
        else if(b>a && b>c)
        {
             Console.WriteLine(b);
        }
        else if(c>a && c>b)
        {
             Console.WriteLine(c);

        }
        }
}