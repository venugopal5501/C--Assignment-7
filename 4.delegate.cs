using System;
class function
{
    delegate int fee(int n);
    public static int feets(int n){


    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the feet measurement : ");
        int feet = Convert.ToInt32(Console.ReadLine());
        fee f=new fee(feets);
        int a;
        feets(feet); 

    }
}