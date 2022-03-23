using System;

class Program
{
    static   void Main() {
    int [] A = new []{7,-5,0};
    int [] B = new []{1,-1,9};
    int C = 0;
    for(int i = 0;i<B.Length;i++)
    {
      C +=(B[i] - A[i]) * (B[i] - A[i]);
    }

        Console.WriteLine( Math.Sqrt(C));
    }



}