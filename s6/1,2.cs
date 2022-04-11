//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//

int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    double number = Convert.ToDouble(Console.ReadLine());
    if (number > 0) count ++;
}
Console.WriteLine(count);

//Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.//
  //  int a = Convert.ToInt32(Console.ReadLine());
  //  int b = Convert.ToInt32(Console.ReadLine());
  //  int[,] matrix = new int[a,b];
  //  for (int i = 0; i < a; i++)
  //  {
  //      for (int j = 0; j < b; j++)
  //      {
  //          if (i == 0 || i == a - 1 || j == 0 || j == matrix.GetLength(1)-1 )
  //          {
  //              matrix[i,j] = 1;
  //          }
  //          else
  //          {
  //              matrix[i,j] = 0;
  //          }
  //              Console.Write(matrix[i,j] + " ");
  //      }
  //      Console.WriteLine();
  //  }
    