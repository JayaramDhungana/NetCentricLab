using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the marks obtained by the student: ");
        int marks = int.Parse(Console.ReadLine());

        char grade = CalculateGrade(marks);
        Console.WriteLine("Grade: " + grade);
    }

    static char CalculateGrade(int marks)
    {
        char grade;

        if (marks >= 90)
        {
            grade = 'A';
        }
        else if (marks >= 80)
        {
            grade = 'B';
        }
        else if (marks >= 70)
        {
            grade = 'C';
        }
        else if (marks >= 60)
        {
            grade = 'D';
        }
        else if (marks >= 50)
        {
            grade = 'E';
        }
        else if (marks >= 40)
        {
            grade = 'F';
        }
        else
        {
            grade = 'F'; // Just Passed
        }

        if (marks < 40)
        {
            grade = 'F'; // Failed
        }

        return grade;
    }
}
