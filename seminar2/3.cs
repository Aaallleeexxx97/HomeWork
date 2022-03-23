using System;

class Program
{
    static      void Main() {
    int a = 3;
    string[] b = new[] {"no","no","no","no","no","yes","yes"};
    if(a>0 && a<8)
    {
        Console.WriteLine(b[a-1]);
    }
    }



}