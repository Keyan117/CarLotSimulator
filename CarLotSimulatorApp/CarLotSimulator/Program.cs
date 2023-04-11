using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            //Done-Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            //Using Dot Notation
            var KeyanCar = new Car();
            KeyanCar.Make = "Ford";
            KeyanCar.Model = "focus";
            KeyanCar.Year = 2013;
            KeyanCar.EngineNoise = "vroom";
            KeyanCar.HonkNoise = "beep";
            KeyanCar.IsDriveable = true;

            lot.Cars.Add(KeyanCar);

            //Object Initializer Syntax
            var StevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = false
            };
            // add stevesCar to the car
            lot.Cars.Add(StevesCar);
            
            //Using the constructor to allow parameter values to be placed inside properties
            var brettCar = new Car(2013,"Honda","Civic", "vrrrooom","vruuuga", true);

            lot.Cars.Add(brettCar);

            //Call methods
            KeyanCar.MakeEngineNoise();
            StevesCar.MakeEngineNoise();
            brettCar.MakeEngineNoise();


            //*************BONUS*************//

            //done-Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //done-Create a CarLot class
            //done-It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberofCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
