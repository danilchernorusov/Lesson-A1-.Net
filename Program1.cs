using System;

public class Program
{
    // The main function
    public static void Main()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter {i + 1} number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int numder1Gsd = gcd(numbers[0], numbers[1]);
        int numder2Gsd = gcd(numder1Gsd, numbers[2]);

        Console.Write("GCD numbers ");
        foreach (int number in numbers)
        {
            Console.Write($"{number}, ");
        }
        Console.WriteLine($"equals {numder2Gsd}.");
    }

    // Function for finding GCD
    public static int gcd(int a, int b)
    {
        if (b == 0)
        {
            return Math.Abs(a);
        }

        return gcd(b, a % b);
    }
}