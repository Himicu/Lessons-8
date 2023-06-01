// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// !!!!!! НЕДОДЕЛАНО !!!!!!! вариант с двумерным массивом

int InputNumber()
{
    int num = new Random().Next(2, 6);
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
// void Perevod(int[,] arr, int[] newArr)
// {
//     for (int i = 0; i < newArr.Length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {

//         }
//     }
// }
void ExcludeDuplicate(int[,] arr, int[,] arr2)
{
    int num1 = 0, num2 = 0;
    // int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
    bool dup = false;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int temp = arr[i, j];
            dup = true;
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int l = 0; l < arr.GetLength(1); l++)
                {
                    if(arr[k, l] == temp){
                        dup = false;
                    }
                   
                }
                 if(dup)
                    {
                        arr2[i, j] = arr[i, j];
                    }
            }
        }
    }
}
// void CountArrayElement(int[,] arr, int num1 = 0, int num2 = 0)
// {
//     int temp = arr[num1, num2], count = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (temp == arr[i, j])
//             {
//                 count++;
//             }
//         }
//     }
//     Console.WriteLine($"Элемент {arr[num1, num2]} был {count} раз");
//     CountArrayElement(arr, num1, num2);
// }
void CountArrayElement(int[,] arr, int num1 = 0, int num2 = 0)
{
    int temp = arr[num1, num2], count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (temp == arr[i, j])
            {
                count++;
            }
        }
    }
    Console.WriteLine($"Элемент {arr[num1, num2]} был {count} раз");
    if (num2 < arr.GetLength(1))
    {
        num2++;
    }
    else
    {
        num1++;
        num2 = 0;
    }
    CountArrayElement(arr, num1, num2);
}

//int row = InputNumber(), colums = InputNumber();
int[,] array = new int[3, 3];
int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
CraeteArray(array);
PrintArray(array);
ExcludeDuplicate(array, newArray);
PrintArray(newArray);
//CountArrayElement(newArray);