﻿namespace DesignPatterns_practice.Structural.Flyweight;

public class FlyweightApplication
{
    public void RunFlyweightScenario()
    {
        var factory = new FlyweightFactory(
            new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
            new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
            new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
            new Car { Company = "BMW", Model = "M5", Color = "red" },
            new Car { Company = "BMW", Model = "X6", Color = "white" }
        );
        factory.PrintFlyweights();

        AddCarToPoliceDatabase(factory, new Car {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "M5",
            Color = "red"
        });

        AddCarToPoliceDatabase(factory, new Car {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "X1",
            Color = "red"
        });

        factory.PrintFlyweights();
    }
    
    private static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
    {
        Console.WriteLine("\nClient: Adding a car to database.");

        var flyweight = factory.GetFlyweight(new Car {
            Color = car.Color,
            Model = car.Model,
            Company = car.Company
        });
        flyweight.Operation(car);
    }
}