using System;

class Car
{
    private string model = "Mustang";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}

public class MyClass
{
    static void Main(String[] args) { 
        Car car = new Car();
    }
}