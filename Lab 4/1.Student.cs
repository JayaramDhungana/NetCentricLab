using System;

// Parent class Student
class Student
{
    protected string roll_no;

    public Student(string roll_no)
    {
        this.roll_no = roll_no;
    }

    public void ReadRollNo()
    {
        Console.Write("Enter roll number: ");
        roll_no = Console.ReadLine();
    }

    public void DisplayRollNo()
    {
        Console.WriteLine("Roll number: " + roll_no);
    }
}

// Child class Test inheriting from Student
class Test : Student
{
    protected float subject1_marks;
    protected float subject2_marks;

    public Test(string roll_no, float subject1_marks, float subject2_marks) : base(roll_no)
    {
        this.subject1_marks = subject1_marks;
        this.subject2_marks = subject2_marks;
    }

    public void ReadMarks()
    {
        Console.Write("Enter marks for subject 1: ");
        subject1_marks = float.Parse(Console.ReadLine());

        Console.Write("Enter marks for subject 2: ");
        subject2_marks = float.Parse(Console.ReadLine());
    }

    public void DisplayMarks()
    {
        Console.WriteLine("Marks for subject 1: " + subject1_marks);
        Console.WriteLine("Marks for subject 2: " + subject2_marks);
    }
}

// Child class Result inheriting from Test
class Result : Test
{
    protected float total;

    public Result(string roll_no, float subject1_marks, float subject2_marks) : base(roll_no, subject1_marks, subject2_marks)
    {
        total = 0;
    }

    public void CalculateTotal()
    {
        total = subject1_marks + subject2_marks;
    }

    public void DisplayTotal()
    {
        Console.WriteLine("Total marks: " + total);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances and demonstrating inheritance
        Result student1 = new Result("A001", 85, 90);
        student1.DisplayRollNo();
        student1.DisplayMarks();
        student1.CalculateTotal();
        student1.DisplayTotal();
    }
}
