using System;
delegate int fee(int n);
class dele
{
    public static int feets(int n)
    {
        int c = n * 12;
        return c;
    }
    public static void Main(string[] args)
    {
        fee d = new fee(feets);
        Console.WriteLine("Enter feet measurements : " );
        int feet = Convert.ToInt32(Console.ReadLine());
        int samp;
        samp = d(feet);
        Console.WriteLine("The inch conversion is "+samp);
    }


}