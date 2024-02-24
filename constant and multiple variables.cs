using System;
class Variable{
    public static void Main(string[] arg)
    {
        Console.WriteLine("This is For Variables");
        string University = "Bangladesh University Of Business And Technology";
        Console.WriteLine(University);

        string var;
        var = "Hello i am Md Salehin.";
        Console.WriteLine("\n");

        Console.WriteLine(var);
        Console.WriteLine(var);
        Console.WriteLine(var);
        var = "Changing any time varibale like thiss.-->>Now my name is MS7";
        Console.WriteLine("Now I want to chage My University Name");
        University = "Mirpur Bangla school\n";
        Console.WriteLine(University);
        
        Console.WriteLine("Const Variable\n");

        Console.WriteLine(var);
        Console.WriteLine(var);
        Console.WriteLine(var);
        const string IdontWantTocHange = "This is i don't want to change so this is the power of const variable\n";
        Console.WriteLine(IdontWantTocHange);


        Console.WriteLine("Now Using Camel Case");
        string CamelCase;
        CamelCase = "CamelCASE using Max Leangth OF word of VARIABLE";
        Console.WriteLine(CamelCase);

         Console.WriteLine("Now for Multiple  Variable\n");

        Console.WriteLine("\n Now for Dynamic Intialization OF Variable");
        Console.WriteLine("Variable declear and initializtion akshate aytake ke dynamic intialization bola hoi");
        string DynamicInitialization = "\n Declear this is called Dynamic Variable\n so this is in the same line thats it";
        Console.WriteLine(DynamicInitialization);
                int num1,num2,num3;
                num1=10;
                num2=10;
                num3=10;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);

        double gpa = 3.60;
        Console.WriteLine(gpa);
        bool isHePassed = true;
        Console.WriteLine(isHePassed);
        char storeChar = 'S';
        Console.WriteLine(storeChar);
        Console.WriteLine("another Process of declare the same value");
                num1=num2=num3=10;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);

    }
}