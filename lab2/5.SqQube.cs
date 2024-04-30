using System;

class SqQube{
    static void Main(string[] args)
    {
        int n1,sq,qube;
        Console.WriteLine("Please enter a number to find square and qube.");
        n1=int.Parse(Console.ReadLine());
        sq=n1*n1;
        qube=n1*n1*n1;
        Console.WriteLine("Square of "+n1+" is "+sq);
        Console.WriteLine("Qube of "+n1+" is "+qube);
        Console.ReadKey();
    }
}