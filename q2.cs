using System;
class Company
{
    private string name;
    private int salary;

    // int salary;
    public Company()
    {
        name = "Mark";
        salary = 1900;
    }
    public Company(string name)
    {
        this.name = name;
        salary = 1900;
    }
    public Company(string n, int s)
    {
        name = n;
        salary = s;

    }
    public string getName()
    {
        return name;
    }
    public int getSalary()
    {
        return salary;

    }
    public void getEmployee()
    {
        Console.WriteLine("Employee name : "+name +"salary"+salary);
    }

    public static void Main(string[] args)
    {
        Company s1 = new Company();
        Company s2 = new Company("Kai");
        Company s3 = new Company("jake", 1800);
        s1.getName();
        s1.getEmployee();
        s2.getEmployee();
        s3.getEmployee();



    }
}