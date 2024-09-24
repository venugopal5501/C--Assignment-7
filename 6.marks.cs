using System;
class marks
{
    public static int[] mark = new int[5];
    public static int[] getMark()
    {

        int sum = 0;
        Console.WriteLine("Enter 5 subject marks");
        for (int i = 0; i < 5; i++)
        {
            mark[i] = Convert.ToInt32(Console.ReadLine());
            if (mark[i] < 0 || mark[i] > 100)
            {
                Console.WriteLine("Please enter the mark between 1 to 100");
                i--;
            }

            sum = sum + mark[i];
        }
        int avg = sum / 5;
        Console.WriteLine("Total Sum of Marks " + sum);
        Console.WriteLine("Average Mark: " + avg);
        return mark;
    }
    public static int isPass(int[] mark)
    {
        int count = 0;
        foreach (int sam in mark)
        {
            if (sam >= 50)
            {
                count++;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        int[] mar = getMark();
        int pa = isPass(mar);
        Console.WriteLine("The number of pass mark is : " + pa);
    }
}
