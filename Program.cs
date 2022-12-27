using System;
using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. Сортировка строк массива \nЗадача 2. \nЗадача 3. \nЗадача 4. \nЗадача 5. \nВведите 0 для выхода\n");
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

            
            break;

        case 3:

            
            break;

        case 4:

            
            break;

        case 5:

            break;

        default:
            begin = false;
            break;
    }
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