using System;
class Datatypes{
    public static void Main(String[] args){
        //Datatypes
        byte b = 10;
        short s = 100;
        int i = 1000;
        long l = 10000L;
        float f = 10.5f;
        double d = 20.75;
        decimal dec = 30.5m;
        char ch = 'A';
        bool flag = true;


        // Implicit Type Conversion
        Console.WriteLine("Implicit Type Conversion:");
        int first = 100;
        long second = first;      // int → long
        double bigDouble = second; // long → double
        Console.WriteLine(bigDouble);

        // Explicit Type Conversion
        Console.WriteLine("Explicit Type Conversion:");
        double num = 99.99;
        int converted = (int)num;   // double → int
        Console.WriteLine(converted);
    }
}