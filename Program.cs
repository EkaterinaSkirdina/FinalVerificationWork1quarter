/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */

void Main()
{
    string[] sourceArray = new string[6] {";-)", "project", "1!", "wow", "...", "world"};
    int lengthElement = 3;
    int size = GetSizeArray(sourceArray, lengthElement);
    string[] apdatedArray = GetNewArray(sourceArray, size, lengthElement);
    PrintArray(apdatedArray);
}

int GetSizeArray(string[] array, int lengthEl)
{
    int size = 0;
    foreach (var element in array)
    {
        if(element.Length <= lengthEl)
        {
            size+=1;
        }
    }
    return size;
}

string[] GetNewArray(string[] inArray, int sizeNewArray, int lengthEl)
{
    string[] newArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
    if(inArray[i].Length <= lengthEl)
        {
        newArray[j] = inArray[i];
        j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length-1]}\"]");
}

Main();

