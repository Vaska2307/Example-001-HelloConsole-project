﻿//int[,] matrix = new int[3, 5];// определили тип данных int [,], дали имя matrix, выделили память под
//элементы массива new int[3, 5] 3 строки и 5 элементов в каждой строке.

// Далее нам неоходимо заполнить двухмерный массив, тоесть обатиться к каждому его элементу и поместить
// туда значение
// 1. Сначала нам нужно пройти по строкам, (одномерным массивам из которых состоит двумерный массив).
// 2. Потом нам нужно пройти по каждой из этих строк (столбцам)
// 3. У нас должно получиться ровно два (2) цикла. 1 Первый будет отвечать за проход по строкам 
//(одномерные массивы). А 2 второй будет отвечать за проход по элементам каждого из этих одномерных 
// массивов (столбцам).
//Random rnd = new Random();
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
   // for (int j = 0; j < matrix.GetLength(1); j++)
   // {
       // matrix[i, j] = rnd.Next(1, 11);
    //}
//}

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
    //for (int j = 0; j < matrix.GetLength(1); j++)
    //{
       // Console.Write($"{matrix[i, j]} ");

    //}
   // Console.WriteLine();// это для того что бы вывести массив в двумерном виде 
//}


int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);