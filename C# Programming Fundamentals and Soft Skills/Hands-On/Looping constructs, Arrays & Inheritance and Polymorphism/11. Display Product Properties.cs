using System;

public class Product
{
    private int productId;
    private String productName;
    private double price;
    
    public int ProductId { get; set; }
    public String ProductName { get; set; }
    public double Price 
    {
        get { return price; }
        set
        {
            if(value > 0)
                price = value;
            else
                price = 0;
        }
    }
    
     public void  Display()
     {
         Console.WriteLine("Product ID : {0}", ProductId);
         Console.WriteLine("Product Name : {0}", ProductName);
         Console.WriteLine("Product Price : {0}", Price);
     }
}

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args)
    {
        Product p = new Product();
    
        Console.WriteLine("Enter product id");
        p.ProductId = int.Parse(Console.ReadLine());
    
        Console.WriteLine("Enter product name");
        p.ProductName = Console.ReadLine();
    
        Console.WriteLine("Enter product price");
        p.Price = double.Parse(Console.ReadLine());
    
        p.Display();
    }
}
