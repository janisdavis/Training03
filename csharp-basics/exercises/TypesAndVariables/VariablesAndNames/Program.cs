﻿using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriven, carsDriven, seatsInACar;
            double  carpoolCapacity, averagePassengersPerCar;

            cars = 100; 
            seatsInACar = 4; 
            drivers = 28; 
            passengers = 90; 
            carsNotDriven = cars - drivers;
            carsDriven = drivers;
            carpoolCapacity = carsDriven * seatsInACar;
            averagePassengersPerCar = Math.Round((carpoolCapacity / passengers), 2);

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " passengers to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
           
            Console.ReadKey();
        }
    }
}