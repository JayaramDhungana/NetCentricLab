using System;

class primitive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Default values of primitive data types:");

        Console.WriteLine("bool: " + default(bool));
        Console.WriteLine("byte: " + default(byte));
        Console.WriteLine("sbyte: " + default(sbyte));
        Console.WriteLine("char: " + default(char));
        Console.WriteLine("short: " + default(short));
        Console.WriteLine("ushort: " + default(ushort));
        Console.WriteLine("int: " + default(int));
        Console.WriteLine("uint: " + default(uint));
        Console.WriteLine("long: " + default(long));
        Console.WriteLine("ulong: " + default(ulong));
        Console.WriteLine("float: " + default(float));
        Console.WriteLine("double: " + default(double));
        Console.WriteLine("decimal: " + default(decimal));

        Console.ReadLine();
    }
}
