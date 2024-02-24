using System;
class Constant
{
    public static void Main(string[] args)
    {
        string University = "Bangladesh University Of Business And Technology";
        Console.WriteLine(University);

        Console.WriteLine("\n");

        Console.WriteLine("Now I want to chage My University Name");
        University = "Mirpur Bangla school\n";
        Console.WriteLine(University);

        Console.WriteLine("Const Variable\n");

        const string IdontWantTocHange = "This is i don't want to change so this is the power of const variable\n";
        Console.WriteLine(IdontWantTocHange);



         Console.WriteLine("Now for Multiple  Variable\n");

                int num1,num2,num3;
                num1=10;
                num2=10;
                num3=10;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);

        Console.WriteLine("another Process of declare the same value");
                num1=num2=num3=10;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);

    }
}