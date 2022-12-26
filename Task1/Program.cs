// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = inputNumber("Введите число: ");
int count = 1;
Print(num, count);

void Print(int num, int count)
{
    if (count > num)
    {
        return;
    }
    else
    {
        Print(num, count + 1);
        Console.Write(count + " ");
    }
}
System.Console.WriteLine();

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