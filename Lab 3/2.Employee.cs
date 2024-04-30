using System;

class Employee
{
    private double salary;
    private int hoursOfWorkPerDay;

    public void GetInfo(double salary, int hoursOfWorkPerDay)
    {
        this.salary = salary;
        this.hoursOfWorkPerDay = hoursOfWorkPerDay;
    }

    public void AddSal()
    {
        if (salary < 500)
        {
            salary += 10;
        }
    }

    public void AddWork()
    {
        if (hoursOfWorkPerDay > 6)
        {
            salary += 5;
        }
    }

    public double GetFinalSalary()
    {
        return salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        
        // Get information of the employee
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        
        Console.Write("Enter number of hours of work per day: ");
        int hoursOfWorkPerDay = int.Parse(Console.ReadLine());
        
        emp.GetInfo(salary, hoursOfWorkPerDay);
        
        // Add salary based on conditions
        emp.AddSal();
        emp.AddWork();
        
        // Print final salary
        Console.WriteLine("Final salary: Rs. " + emp.GetFinalSalary());
    }
}
