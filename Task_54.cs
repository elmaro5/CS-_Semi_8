// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = 9;
int n = 8;

int[,] arr = FillArray(m, n);

int[,] FillArray(int m, int n)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return array;
}
System.Console.WriteLine();
arrayBubble(arr);

void arrayBubble(int[,] arr)
{
    for (int k = 0; k <  arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {

            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {

                if (arr[k, j] > arr[k, j + 1])
                {
                    int temp = arr[k, j];
                    arr[k, j] = arr[k, j + 1];
                    arr[k, j + 1] = temp;
                }

            }
        }
    }
    printArray(arr);
}



void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}