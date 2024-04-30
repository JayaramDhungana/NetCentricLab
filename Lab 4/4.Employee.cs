using System;

// Parent class Member
class Member
{
    protected string name;
    protected int age;
    protected string phone;
    protected string address;
    protected double salary;

    // Method to initialize member details
    public void SetMemberDetails(string name, int age, string phone, string address, double salary)
    {
        this.name = name;
        this.age = age;
        this.phone = phone;
        this.address = address;
        this.salary = salary;
    }

    // Method to print member details
    public void PrintMemberDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Phone: " + phone);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Salary: " + salary);
    }
}

// Subclass Employee inheriting from Member
class Employee : Member
{
    protected string specialization;

    // Method to set specialization
    public void SetSpecialization(string specialization)
    {
        this.specialization = specialization;
    }

    // Method to print specialization
    public void PrintSpecialization()
    {
        Console.WriteLine("Specialization: " + specialization);
    }
}

// Subclass Manager inheriting from Member
class Manager : Member
{
    protected string department;

    // Method to set department
    public void SetDepartment(string department)
    {
        this.department = department;
    }

    // Method to print department
    public void PrintDepartment()
    {
        Console.WriteLine("Department: " + department);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object of Employee and setting details
        Employee employee = new Employee();
        employee.SetMemberDetails("John Doe", 30, "1234567890", "123 Main St", 50000);
        employee.SetSpecialization("Software Developer");

        // Creating object of Manager and setting details
        Manager manager = new Manager();
        manager.SetMemberDetails("Jane Smith", 40, "9876543210", "456 Broad St", 80000);
        manager.SetDepartment("HR");

        // Printing details of Employee and Manager
        Console.WriteLine("Employee Details:");
        employee.PrintMemberDetails();
        employee.PrintSpecialization();

        Console.WriteLine("\nManager Details:");
        manager.PrintMemberDetails();
        manager.PrintDepartment();
    }
}
