using System;
class reverse
{
    public void rever(string word, int len)
    {
        if (len < 0)
        {
            return;
        }
        char[] arr = word.ToCharArray();
        Console.Write(arr[len]);
        rever(word, len - 1);
    }
    public static void Main(string[] args)
    {
        string r = Console.ReadLine();
        int length = r.Length - 1;
        reverse rb = new reverse();
        rb.rever(r, length);

    }
}