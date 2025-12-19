using System;

class Operators{
    public static void Main(String[] args){
        int a=10;
        int b=3;

        //Arithematic operators
        Console.WriteLine("Arithematic Operators");
        Console.WriteLine(a+b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);

        // relational operators
        Console.WriteLine("Relational Operators");
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a <= b);

        // logical Operators
        bool x = true, y = false;
        Console.WriteLine("Logical Operators");
        Console.WriteLine(x && y);
        Console.WriteLine(x || y);
        Console.WriteLine(!x);

        // Assignment Operators
        Console.WriteLine("Assignment Operators");
        int c = 5;
        c += 2;
        Console.WriteLine(c);
        c -= 1;
        Console.WriteLine(c);
        c *= 2;
        Console.WriteLine(c);
        c /= 2;
        Console.WriteLine(c);
        c %= 2;
        Console.WriteLine(c);


        // unary Operators
        Console.WriteLine("Unary Operators");
        int d = 5;
        Console.WriteLine(++d);
        Console.WriteLine(--d);

        // Bitwise Operators
        Console.WriteLine("Bitwise Operators");
        Console.WriteLine(a & b);
        Console.WriteLine(a | b);
        Console.WriteLine(a ^ b);
        Console.WriteLine(~a);
        Console.WriteLine(a << 1);
        Console.WriteLine(a >> 1);

        // Ternary Operator
        Console.WriteLine("Ternary Operator");
        int max = (a > b) ? a : b;
        Console.WriteLine(max);

        // Type Operators
        Console.WriteLine("Type Operators");
        Console.WriteLine(a is int);
        Console.WriteLine(typeof(int));
        object obj = a;
        int num = obj as int? ?? 0;
        Console.WriteLine(num);


    }
}