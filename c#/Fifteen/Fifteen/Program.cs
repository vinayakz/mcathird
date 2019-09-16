using System;


public class C1
{

    public string rn;
    public string name;

}

public class C2
{
    public static void Main(string[] args)
    {
        C1 obj = new C1();
        obj.rn = "CA172008";
        obj.name = "vinoo";
        Console.WriteLine("Name:  {0} \nRoll No: {1}", obj.name, obj.rn);
        Console.ReadLine();

    }
}