using System;
using System.Text.RegularExpressions;
class sum
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int sum = 0;
        foreach(char c in word)
        {
            if (char.IsDigit(c))
            {
                sum = sum + int.Parse(c.ToString());
            }
        }
        Console.WriteLine(sum);
    }
}