using System;
class ncr
{
    static int factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        int fact = 1;

        fact = n * factorial(n - 1);
        return fact;
        // Console.Write(fact);

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value for n : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value for r : ");
        int r = Convert.ToInt32(Console.ReadLine());
        int calc = factorial(n) / (factorial(r) * factorial(n - r));
        Console.Write("The Value of ncr is " + calc);


    }
}