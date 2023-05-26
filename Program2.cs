using System;

namespace Program
{
    class Program
    {
        // The main function
        public static void Main()
        {
            int number = InputNumber();
            int closestPrimeNumber = ClosestPrimeNumber(number);
            Console.WriteLine($"The largest prime number for {number} is {closestPrimeNumber}.");
        }

        // Function for entering numbers
        public static int InputNumber() 
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            return number;
        }

        // A function to determine whether a number is prime or not
        public static bool IsPrime(int number) 
        { 
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        // A function for finding the nearest even number
        public static int ClosestPrimeNumber(int number)
        {
            int number1 = number + 1;
            bool isPrime1 = IsPrime(number1);
            while (!isPrime1) 
            {
                number1++;
                isPrime1 = IsPrime(number1);
            }

            // The following lines are performed for numbers less than which are prime numbers
            if (number > 2)
            {
                int number2 = number - 1;
                bool isPrime2 = IsPrime(number2);
                while (!isPrime2)
                {
                    number2--;
                    isPrime2 = IsPrime(number2);
                }

                if ((number1 - number) > (number - number2))
                {
                    return number2;
                }
            }

            // If the condition on line 62 is not fulfilled, we output number1
            return number1;
        }
    }
}