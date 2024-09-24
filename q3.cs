using System;

struct Inventory
{
    public string name;
    public string color;
    public double cost;
    public string size;

    public Inventory(string name, string color, string size, double cost)
    {
        this.name = name;
        this.color = color;
        this.cost = cost;
        this.size = size;

    }
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Colour: " + color);
        Console.WriteLine("Size: " + size);
        Console.WriteLine("Cost: " + cost);
        Console.WriteLine();
    }
}
class program
{
    public static void Main(string[] args)
    {
        Inventory in1 = new Inventory("Shirt", "Blue", "Medium", 56.50);
        Inventory in2 = new Inventory("Shoes", "Black", "Large", 55.75);
        Inventory in3 = new Inventory("Jacket", "Red", "Small", 42.20);
        // in1.Display();

        Inventory high=in1;
        if(in1.cost>in2.cost || in1.cost>in3.cost){
            high=in1;
        }
        if(in2.cost>in1.cost || in2.cost>in3.cost){
            high=in2;
        }
        if(in3.cost>in1.cost || in3.cost>in2.cost ){
            high=in3;
        }
        high.Display();
    }
}

