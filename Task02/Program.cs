using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        int sum = CalculateDigitSum(input);

        Console.WriteLine($"Сумма цифр в числе = {sum}");
    }

    static int CalculateDigitSum(string input)
    {
        int sum = 0;

        foreach (char c in input)
        {
            if (Char.IsDigit(c))
            {
                sum += int.Parse(c.ToString());
            }
        }

        return sum;
    }
}
