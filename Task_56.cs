
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



int m = 4;
int n = 5;

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

arrayCountMinSumm(arr);

void arrayCountMinSumm(int[,] arr)
{
    int summ = 9999;
    int lineNum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summTemp = 0;
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summTemp += arr[i,j];
        }
        if (summTemp < summ) 
        {
            summ = summTemp;
            lineNum = i;
        }
    }
 
    System.Console.WriteLine($"Ряд с минимальным значением: {lineNum}");

}



