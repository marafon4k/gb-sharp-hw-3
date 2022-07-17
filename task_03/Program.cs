// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void Pow()
{
    int i = 0;
    while (i == 0)
    {
        Console.WriteLine("Enter number");
        if (int.TryParse(Console.ReadLine(), out var number))
        {
            if (number == 1) break;

            double hoarder = 0;

            while (hoarder < number)
            {
                double dev = number;
                hoarder++;
                dev = Math.Pow(hoarder, 3);
                Console.WriteLine($" | {dev} | ");
            }
            Console.WriteLine("Write 1 if you want to stop");
        }
    }
}

Pow();