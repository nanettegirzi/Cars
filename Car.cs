using System;
using System.Collections.Generic;

class Car
{
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;

    public Car(string carMakeModel, int carPrice, int carMiles, string carMessage)
    {
        _makeModel = carMakeModel;
        _price = carPrice;
        _miles = carMiles;
        _message = carMessage;
    }

    public void SetPrice(int newPrice)
    {
        _price = newPrice;
    }

    public string GetMakeModel()
    {
        return _makeModel;
    }
    public string GetMessage()
    {
        return _message;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetMiles()
    {
        return _miles;
    }

}

public class Program
{
    public static void Main()
    {
        Car porsche = new Car("2014 Porsche 911",114991,7864,"fast");
        Car ford = new Car("2011 Ford F450",55995,14241,"large and expensive");
        Car lexus = new Car("2013 Lexus RX 350",44700,20000,"luxury");
        Car mercedes = new Car("Mercedes Benz CLS550",39900,37979,"German");

        List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

        foreach(Car automobile in Cars)
        {
            Console.WriteLine(automobile.GetMakeModel() +" "+ automobile.GetMessage());
        }

        Console.WriteLine("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);

        List<Car> CarsMatchingSearch = new List<Car>();

        foreach (Car automobile in Cars)
        {
            if (automobile.GetPrice() < maxPrice)
            {
                CarsMatchingSearch.Add(automobile);
            }
        }

        Console.WriteLine("Enter maximum milage: ");
        string stringMaxMilage = Console.ReadLine();
        int maxMilage = int.Parse(stringMaxMilage);

        List<Car> CarsMatchingSearch2 = new List<Car>();

        foreach (Car automobile in CarsMatchingSearch)
        {
            if (automobile.GetMiles() < maxMilage)
            {
                CarsMatchingSearch2.Add(automobile);
            }
        }

        foreach(Car automobile in CarsMatchingSearch2)
        {
            Console.WriteLine(automobile.GetMakeModel(), automobile.GetMessage());
        }

        if (CarsMatchingSearch2.Count==0)
        {
            Console.WriteLine("No cars for you!");
        }


    }
}
