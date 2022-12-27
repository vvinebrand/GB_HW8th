using System;
using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. Сортировка строк массива \nЗадача 2. Поиск строки с наименьшей суммой элементов\nЗадача 3. Произведение двух матриц\nВведите 0 для выхода\n");
    Console.Write("Введите номер задачи: ");
    programm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (programm)
    {
        case 1:

            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");
            Console.WriteLine();

            int[,] array = new int[m, n];
            CreateArray(array);
            WriteArray(array);

            Console.WriteLine($"\nОтсортированный массив: \n");
            OrderArrayLines(array);
            WriteArray(array);

            void OrderArrayLines(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                int temp = array[i, k + 1];
                                array[i, k + 1] = array[i, k];
                                array[i, k] = temp;
                            }
                        }
                    }
                }
            }

            break;

        case 2:

            int a = InputNumbers("Введите m: ");
            int b = InputNumbers("Введите n: ");

            int[,] array_2 = new int[a, b];
            CreateArray(array_2);
            WriteArray(array_2);

            int minSumLine = 0;
            int sumLine = SumLineElements(array_2, 0);
            for (int i = 1; i < array_2.GetLength(0); i++)
            {
                int tempSumLine = SumLineElements(array_2, i);
                if (sumLine > tempSumLine)
                {
                    sumLine = tempSumLine;
                    minSumLine = i;
                }
            }

            Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой элементов ({sumLine}) ");

            break;

        case 3:

            int q = InputNumbers("Введите число строк 1-й матрицы: ");
            int w = InputNumbers("Введите число столбцов 1-й матрицы/Строк второй: ");
            int e = InputNumbers("Введите число столбцов 2-й матрицы: ");
            Console.WriteLine();

            int[,] firstMartrix = new int[q, w];
            CreateArray_2(firstMartrix);
            Console.WriteLine("Первая матрица: ");
            WriteArray(firstMartrix);
            Console.WriteLine();

            int[,] secomdMartrix = new int[w, e];
            CreateArray_2(secomdMartrix);
            Console.WriteLine("Вторая матрица: ");
            WriteArray(secomdMartrix);
            Console.WriteLine();

            int[,] resultMatrix = new int[q, e];

            MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
            Console.WriteLine("Произведение первой и второй матриц:");
            WriteArray(resultMatrix);

            break;
        default:
            begin = false;
            break;
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10,99);
        }
    }
}

void CreateArray_2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}