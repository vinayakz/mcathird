using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class baseClass
{
    public virtual void show()
    {
        Console.WriteLine("Base class");
    }
}


class derived : baseClass
{
    public override void show()
    {
        Console.WriteLine("Derived class");
    }
}

class GFG
{
    public static void Main()
    {

        baseClass obj;
        obj = new baseClass();
        obj.show();
        obj = new derived();
        obj.show();
        Console.ReadLine();

    }
}