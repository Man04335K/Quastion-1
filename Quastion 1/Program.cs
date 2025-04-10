using System;

class Car
{
    // Properties of the Car class
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor to initialize a new Car object
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Method to display the car's information
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Make: {Make}");
        Console.WriteLine($"Car Model: {Model}");
        Console.WriteLine($"Year of Manufacture: {Year}");
        Console.WriteLine();  // Empty line for spacing
    }
}

class Program
{
    static void Main()
    {
        // Create two different Car objects
        Car car1 = new Car("Toyota", "Corolla", 2020);
        Car car2 = new Car("Honda", "Civic", 2022);

        // Display information of both cars
        Console.WriteLine("Car 1 Information:");
        car1.DisplayInfo();

        Console.WriteLine("Car 2 Information:");
        car2.DisplayInfo();
    }
}