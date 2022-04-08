using System;

class Program
{
    static void Main() 
    {
     int x = Convert.ToInt32 (Console. ReadLine());
     int y = Convert.ToInt32 (Console. ReadLine());
     Console.WriteLine(Task1(x,y));
    }
    static int Task1 (int xValue, int yValue)
    {
      int b=xValue; 
        for(int i=1; i<yValue; i++) 
        {
          xValue*=b;
        }
        return xValue;

    }

}