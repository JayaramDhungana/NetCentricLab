using System;

class swaping{
    public static void Main(string [] args){
    int N1,N2,N3;
    Console.WriteLine("Please enter first Number as N1");
    N1=int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter Second Number as N2");
    N2=int.Parse(Console.ReadLine());
    Console.WriteLine("Before Swapping \nN1="+N1+"\nN2="+N2);
    N3=N1;
    N1=N2;
    N2=N3;
    Console.WriteLine("Before Swapping \nN1="+N1+"\nN2="+N2);
    }

}