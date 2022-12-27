using System.Text;

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("\nЗадача 1. \nЗадача 2. \nЗадача 3. \nЗадача 4. \nЗадача 5. \nВведите 0 для выхода\n");
    Console.Write("Введите номер задачи: ");
    programm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (programm)
    {
        case 1:

            
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