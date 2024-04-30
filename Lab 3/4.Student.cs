using System;
using System.Collections.Generic;

class Student
{
    // Data Members
    public int StudentID { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Department { get; set; }
    public List<string> CourseList { get; set; }
    public double GPA { get; set; }
    public int CreditsEarned { get; set; }
    public Dictionary<string, bool> Attendance { get; set; }
    public Dictionary<string, string> Grades { get; set; }

    // Constructor
    public Student(int id, string name, DateTime dob, string address, string email, string phone, string department)
    {
        StudentID = id;
        Name = name;
        DateOfBirth = dob;
        Address = address;
        Email = email;
        PhoneNumber = phone;
        Department = department;
        CourseList = new List<string>();
        GPA = 0.0;
        CreditsEarned = 0;
        Attendance = new Dictionary<string, bool>();
        Grades = new Dictionary<string, string>();
    }

    // Methods
    public void RegisterForCourse(string course)
    {
        CourseList.Add(course);
    }

    public void DropCourse(string course)
    {
        CourseList.Remove(course);
    }

    public void ViewCourseSchedule()
    {
        Console.WriteLine("Courses enrolled:");
        foreach (var course in CourseList)
        {
            Console.WriteLine(course);
        }
    }

    public void CheckGPA()
    {
        Console.WriteLine("GPA: " + GPA);
    }

    public void ViewTranscript()
    {
        Console.WriteLine("Transcript:");
        foreach (var grade in Grades)
        {
            Console.WriteLine(grade.Key + ": " + grade.Value);
        }
    }

    public void ViewAttendance(string course)
    {
        if (Attendance.ContainsKey(course))
        {
            Console.WriteLine("Attendance for " + course + ": " + (Attendance[course] ? "Present" : "Absent"));
        }
        else
        {
            Console.WriteLine("Attendance for " + course + " not available.");
        }
    }

    public void ViewGrades(string course)
    {
        if (Grades.ContainsKey(course))
        {
            Console.WriteLine("Grade for " + course + ": " + Grades[course]);
        }
        else
        {
            Console.WriteLine("Grade for " + course + " not available.");
        }
    }

    public void UpdateContactInformation(string newAddress, string newEmail, string newPhone)
    {
        Address = newAddress;
        Email = newEmail;
        PhoneNumber = newPhone;
    }

    public void CalculateCredits()
    {
        // Calculate total credits from the courses enrolled
        CreditsEarned = CourseList.Count * 3; // Assuming each course is worth 3 credits
    }

    public void ViewProfile()
    {
        Console.WriteLine("Student Profile:");
        Console.WriteLine("ID: " + StudentID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Date of Birth: " + DateOfBirth.ToShortDateString());
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone Number: " + PhoneNumber);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("GPA: " + GPA);
        Console.WriteLine("Credits Earned: " + CreditsEarned);
        Console.WriteLine("Courses Enrolled:");
        foreach (var course in CourseList)
        {
            Console.WriteLine("- " + course);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a sample student
        Student student = new Student(123456, "John Doe", new DateTime(2000, 5, 15), "123 Main St", "john.doe@example.com", "123-456-7890", "Computer Science");

        // Register for courses
        student.RegisterForCourse("Programming Fundamentals");
        student.RegisterForCourse("Database Management");

        // View course schedule
        student.ViewCourseSchedule();

        // View profile
        student.ViewProfile();
    }
}
