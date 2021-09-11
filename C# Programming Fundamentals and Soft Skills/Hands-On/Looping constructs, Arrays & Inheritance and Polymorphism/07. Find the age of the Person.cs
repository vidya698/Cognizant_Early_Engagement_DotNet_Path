using System;
using System.IO;

public class Person
{
    private string firstName;
    private string lastName;
    private DateTime dob;


public string FirstName{
    get{return firstName;}
    set {firstName = value;}
}

public string LastName
{
 get {return lastName;}
 set {lastName= value;}
}
public DateTime Dob{
    get{return dob;}
    set{dob= value;}
}

public string Adult {
    get{
        if(GetAge(dob)< 18)
        return "child";
        else 
        return "Adult";
    }
}
 public void DisplayDetails()
    {
       Console.WriteLine("First Name: " + FirstName);
       Console.WriteLine("Last Name: " + LastName);
       Console.WriteLine("Age: " + GetAge(dob));
       Console.WriteLine(Adult);
    }
    
    public int GetAge(DateTime dob)
    {
        DateTime Now = DateTime.Now; 
        int age = 0;
        age = DateTime.Now.Year - dob.Year;  
        if (DateTime.Now.DayOfYear < dob.DayOfYear)  //This is for leap year
            age = age - 1;  
        return age;  
    }
}

public class BirthdayProject 
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        Console.WriteLine("Enter first name");
        person.FirstName = Console.ReadLine();
    
        Console.WriteLine("Enter last name");
        person.LastName = Console.ReadLine();
        
        Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
        person.Dob = Convert.ToDateTime(Console.ReadLine());

        person.DisplayDetails(); 
    }
}
