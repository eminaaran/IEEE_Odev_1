using System;

class Program
{
    static void Main()
    {
        int n = 100;

        int sumOfSquares = 0;
        for (int i = 1; i <= n; i++)
        {
            sumOfSquares += i * i;
        }

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        int squareOfSum = sum * sum;

        int difference = squareOfSum - sumOfSquares;

        Console.WriteLine("Karelerin toplamı: " + sumOfSquares);
        Console.WriteLine("Toplamın karesi: " + squareOfSum);
        Console.WriteLine("Fark: " + difference);
    }
}
