using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        double result = CalculatePower(A, B);

        Console.WriteLine($"{A} в степени {B} равно {result}");
    }

    static double CalculatePower(double A, int B)
    {
        double result = 1.0;

        if (B >= 0)
        {
            for (int i = 0; i < B; i++)
            {
                result *= A;
            }
        }
        else
        {
            for (int i = 0; i < -B; i++)
            {
                result /= A;
            }
        }

        return result;
    }
}

