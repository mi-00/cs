using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Hesperange", 8);

            Console.WriteLine("Hello Mihaela!");
            Console.WriteLine("car location + car number of seats: " + audi.Location + " + " + audi.NumberOfSeats);

            audi.MoveTo("Luxembourg");
            Console.WriteLine("car location + car number of seats: " + audi.Location + " + " + audi.NumberOfSeats);

        }
    }
}
