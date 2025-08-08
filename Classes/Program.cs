namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Toyota";
            carOne.Model = "Corolla";
            carOne.Year = 2020;
            
            Console.WriteLine($"This is a {carOne.Make}  {carOne.Model}, made in the year {carOne.Year}. Sexy ride huh!");
        }
    }
}
