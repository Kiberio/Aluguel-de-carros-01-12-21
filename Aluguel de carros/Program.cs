//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Globalization;

namespace Aluguel_de_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rental car info
            Console.WriteLine("Enter car rental data:");
            Console.Write("model: ");
            string model = Console.ReadLine();
            Console.Write("Check-in (dd / MM / yyyy HH: mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check-out (dd / MM / yyyy HH: mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //price per hour
            Console.Write("Enter the hourly price: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Price per day
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Creat carRental list
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            //Creat RentalService vector to calculate invoice
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);
            //Print out invoice the rental
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
            Console.ReadKey();
        }
    }
}
