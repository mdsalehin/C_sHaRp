// Assignment - 2
using System;
class Assignment{
    public static void Main(string[] arg)
    {
        string Name = "Apple Iphone";
        double price = 320.5;
        string category = "smart phone";
        bool available = true;
        int sold = 5;

        Console.WriteLine(Name);
        Console.WriteLine(price);
        Console.WriteLine($"${price}"); 
        Console.WriteLine(category);
        Console.WriteLine(available);
        Console.WriteLine(sold);
    }
}