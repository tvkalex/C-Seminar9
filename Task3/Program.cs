// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = inputNumber("Введите число M: ");
int n = inputNumber("Введите число N: ");
AkkermanFunction(m,n);
System.Console.WriteLine();

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

int inputNumber(string str)
{
    {
        int number;
        string text;

        while (true)
        {
            System.Console.Write(str);
            text = Console.ReadLine()!;
            if (int.TryParse(text, out number))
            {
                break;
            }
            System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
        }
        return number;
    }
}