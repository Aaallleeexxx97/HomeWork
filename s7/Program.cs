
using System;

class Program
{  
/*    static void Main()
    {
        int m = Convert.ToInt32 (Console. ReadLine());
        int n = Convert.ToInt32 (Console. ReadLine());
        NewRandomDoubleArray(m,n);
    }
    static void NewRandomDoubleArray (int m, int n) 
    {
        double[,] matrix = new double [m,n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix [i,j] = new Random().NextDouble() ;
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
    } 
    */
    
// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
  static void Main()
    {
        int m = Convert.ToInt32 (Console. ReadLine());
        int n = Convert.ToInt32 (Console. ReadLine());
        CreateMatrixOfInteger(m,n);
    }
 static int[,] CreateMatrixOfInteger(int m, int n)
    {
        int[,] matrix = new int[m, n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 10);
            }
        } 
        return matrix;
    }
void PrintMatrix<T>(T[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
}