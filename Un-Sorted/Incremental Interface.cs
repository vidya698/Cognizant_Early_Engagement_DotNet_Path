using System;
using System.IO;

abstract class Employee
{
    protected string name;
    protected double salary;

    public Employee()
    {
        Console.WriteLine("");
    }

    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public void Print()
    {
        Console.WriteLine(name);
        Console.WriteLine(salary);
    }
}

interface IIncrementable
{
    double Increment();
}

class Manager : Employee, IIncrementable
{
    protected string teamId;

    public Manager(string teamId)
    {
        this.teamId = teamId;
    }

    public Manager(string name, double salary, string teamId)
    {
        this.name = name;
        this.salary = salary;
        this.teamId = teamId;
    }

    public double Increment()
    {
        salary = salary + (salary * 0.5);
        return salary;
    }
}

class Programmer : Employee, IIncrementable
{
    protected string domain;

    public Programmer(string domain)
    {
        this.domain = domain;
    }

    public Programmer(string name, double salary, string domain)
    {
        this.name = name;
        this.salary = salary;
        this.domain = domain;
    }

    public double Increment()
    {
        salary = salary + (salary * 0.1);
        return salary;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the details of Manager");
        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        string teamId = Console.ReadLine();

        Manager m = new Manager(name, salary, teamId);

        Console.WriteLine("Enter the details of Programmer");
        string pname = Console.ReadLine();
        double psalary = double.Parse(Console.ReadLine());
        string domain = Console.ReadLine();

        Programmer p = new Programmer(pname, psalary, domain);

        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Salary : {m.Increment()}");

        Console.WriteLine($"Name : {pname}");
        Console.WriteLine($"Salary : {p.Increment()}");

    }
}