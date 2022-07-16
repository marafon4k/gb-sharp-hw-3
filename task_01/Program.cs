Console.Clear();

// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> No
// 12821 -> Yes
// 23432 -> Yes

void Poly()
{
    int i = 1;
    while (i == 1)
    {
        Console.WriteLine("Enter number");
        if (int.TryParse(Console.ReadLine(), out var num))
        {
            if (num == 1) break;

            int dig = 0,
                rev = 0,
                numb = num;
            while (num > 0)
            {
                dig = num % 10; // 14212 2 1 2 4 1 stop
                rev = rev * 10 + dig; // 2 21 212 2124 21241
                num = num / 10; // 14212 1421 142 14 1 0
            }
            if (numb == rev) Console.WriteLine("Yes"); else Console.WriteLine("No");
            Console.WriteLine("Write 1 if you want to stop");
        }
    }
}

Poly();