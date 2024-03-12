void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)//
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int [] col) // void если метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если не бкдет ни одного элемента, то возвращать значение -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив в котором будет 10 элементов

FillArray(array); // заполнил нам массив
array[4] = 4; //принудительно добавили 4(четверки в массив);
array[6] = 4; //принудительно добавили 4(четверки в массив);

PrintArray(array); // распечатал
Console.WriteLine();

int pos = IndexOf(array, 444); // добавили число которое точно не существует в массиве
Console.WriteLine(pos);
