using System;
using static System.Console;

//Clear();
// Функция для создания (формирования) двумерного массива НИЖЕ
int[,] CreateMatrix(int rowCount, int columsCount)// Функция, он же метод выделение памяти делаем гибким
{
    int[,] matrix = new int[rowCount, columsCount];// создание массива

    Random rnd = new Random();// заполнение массива случайными числами
    for (int i = 0; i < matrix.GetLength(0); i++)// проход по строкам массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам (элементам) массива
        {
            matrix[i, j] = rnd.Next(1, 1000); // диапазон генерации чисел rnd.Next(1, 1000);
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
            Console.Write($"{matrix[i, j]} ");// интерполяция строк

        }
        Console.WriteLine();
    }
}

// для дальнейшей работы создадим двумерный массив
int[,] matrix = CreateMatrix(3, 4);// назовем переменную  matrix вызовим функцию создания двумерного 
//массива = по имени CreateMatrix, на 3 строки 4 столбца (3, 4);
ShowMatrix(matrix);
foreach (int item in matrix)// цикл который будет осуществлять перебор элементов массива. 
                            //Элемент массива int item и сам массив in matrix
{
    if (IsInteresting(item) == true)
    {
        WriteLine($"{item} ");
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;

}
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}