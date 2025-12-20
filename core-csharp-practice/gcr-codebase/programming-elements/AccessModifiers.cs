using System;
class BaseClass{
    private int a = 10; // Only inside baseclass
    protected int b = 20; // baseclass + derived class
    internal int c = 30;  //same project
    public int d = 40;    // everywhere

    private protected int e = 50;    // Same project AND derived class
    protected internal int f = 60;  // Same project OR derived class(either)

    public void ShowBase(){
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
    }
}

class DerivedClass : BaseClass{
    public void ShowDerived(){
        // Console.WriteLine(a); //private not accessible
        Console.WriteLine(b);   // protected
        Console.WriteLine(c);   // internal
        Console.WriteLine(d);   // public
        Console.WriteLine(e);   // private protected
        Console.WriteLine(f);   // protected internal
    }
}

class AccessModifiers{
    static void Main(){
        BaseClass obj = new BaseClass();
        obj.ShowBase();

        // Console.WriteLine(obj.b); //protected not accessible
        Console.WriteLine(obj.c); // internal
        Console.WriteLine(obj.d); // public
        // Console.WriteLine(obj.e); //private protected not accessible
        Console.WriteLine(obj.f); // protected internal

        DerivedClass d = new DerivedClass();
        d.ShowDerived();
    }
}
