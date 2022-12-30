// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 


/*
int n = 0;
int m = 0;
int g = 0;
Console.WriteLine("Столбец");
n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Строка");
m=Convert.ToInt32(Console.ReadLine());
int [,]  mas = new int[n, m];
Random rand = new Random();
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
     mas[i,j]=rand.Next(-20,20);
     Console.Write(mas[i, j] + "    ");
    }
    Console.WriteLine();
}
for(int u=0;u<m*n;u++)
{
 for(int z=0;z<n;z++)
 { 
    for(int x = 1; x < m; x++)
    {
        if(mas[z,x]>mas[z,x-1])
        {
            g=mas[z,x];
            mas[z,x]=mas[z,x-1];
            mas[z,x-1]=g;
        }
    }
 }
}
for(int l=0;l<n;l++)
{
    for(int o = 0; o < m; o++)
    {   
            Console.Write(mas[l,o] + "  ");     
    }
    Console.WriteLine();
}
*/










// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


/*
int n = 0;
int m = 0;
int g = 0;
int k = 100;
int j = 0;
int z = 0;
Console.WriteLine("Столбец");
n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Строка");
m=Convert.ToInt32(Console.ReadLine());
int [,]  mas = new int[n, m];
Random rand = new Random();
for(int i = 0; i < n; i++)
{
    g=0;
    for( j = 0; j < m; j++)
    {
     mas[i,j]=rand.Next(10);
     Console.Write(mas[i, j] + "    ");
     g+=mas[i,j];
    }
    if(g<k)
    {
        k=g;
        z=i+1;
    }
    
    Console.WriteLine();
}
Console.WriteLine("{0} наименьшая сумма ", k);
Console.WriteLine("{0} строка с наименьшей суммой" , z);
*/









// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 


/*
int [,]  mas = new int[2,2];
int [,]  mas1 = new int[2,2];
int [,]  mas2 = new int[2,2];
Random rand = new Random();
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
     mas[i,j]=rand.Next(1,20);
     Console.Write(mas[i, j] + "    ");
    }
    Console.WriteLine();
}
Console.WriteLine("      ");
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
     mas1[i,j]=rand.Next(1,20);
     Console.Write(mas1[i, j] + "    ");
    }
    Console.WriteLine();
}
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        for(int k=0;k< 2;k++)
        {
     mas2[i,j]+=mas[i,k]*mas1[k,j];

        }

    }
    Console.WriteLine();
}
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
     Console.Write(mas2[i, j] + "    ");
     
    }
    Console.WriteLine();

}     
*/








// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером: 2 x 2 x 2.


/*
int[,,] mas = new int[2, 2, 2];
FillArray(mas);
PrintIndex(mas);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                Console.Write($"{mas[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
*/







// Напишите программу, которая заполнит спирально массив 4 на 4. 


/*
int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/