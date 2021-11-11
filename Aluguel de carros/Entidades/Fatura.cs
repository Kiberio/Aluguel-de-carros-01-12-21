using System;
using System.Globalization;

namespace Aluguel_de_carros
{
    class Invoice
    {
        //Variant to invoice 
        public double BasicPayment { get; set; }
        //Constructors
        public double Tax { get; set; }
        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }
        //Variant to TotalPayment of invoice
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        //ToString to print basic payment ,tax and total payment
        public override string ToString()
        {
            return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    //Vehicle class to store the model
        class Vehicle
        {
            public string Model { get; set; }
            public Vehicle(string model)
            {
                Model = model;
            }
        }
    //CarRental class to creat variants and store information
        class CarRental
        {
            public DateTime Start { get; set; }
            public DateTime Finish { get; set; }
            public Vehicle Vehicle { get; private set; }
            public Invoice Invoice { get; set; }
        //Constructor
            public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
            {
                Start = start;
                Finish = finish;
                Vehicle = vehicle;
                Invoice = null;
            }
        }
    }
   

