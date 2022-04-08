using System;

class Program
{
    static void Main() 
    {
     string x = Console.ReadLine();
     Console.WriteLine(Task1(x));
    }
    static int Task1 (string xValue)
    {
        int b=0;
        for(int i=0; i<xValue.Length; i++) 
        {
              b+=Convert.ToInt32(new string(xValue[i], 1));
        }
        return b;

    }

}