using System;

namespace Classes
{
    class Programs
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var Mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX5",
                Year = 2016,
            };

            var chevy = new Car("Chevy", "Impala", 2001);


            var carList = new List<Car>() { myCar, Mazda, chevy };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{ vehicle.Make} {vehicle.Model} {vehicle.Year }");
            }
        }
    }
}
