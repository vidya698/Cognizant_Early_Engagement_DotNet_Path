using System;

public class Person
{
    private String firstName;
    private String lastName;
    private DateTime dob;
    
    public String FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    
    public String LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    
    public DateTime Dob
    {
        get { return dob; }
        set { dob = value; }
    }
    
    public string Adult
    {
        get
        {
            if(GetAge(dob) < 18)
                return "Child";
            else
                return "Adult";
        }
    }
    
    public void DisplayDetails()
    {
       Console.WriteLine("First Name: " + firstName);
       Console.WriteLine("Last Name: " + lastName);
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

public class BirthdayProject      //DO NOT change the class name
{
    //implement code here
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
