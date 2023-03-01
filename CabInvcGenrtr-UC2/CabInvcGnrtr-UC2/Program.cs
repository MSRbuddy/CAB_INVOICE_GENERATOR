using CabInvoiceGenerator;
using System.IO;

namespace CabInvcGnrtr_UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Innvoice Generator UC-2!");
            
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(2.0, 5), new Ride(1.0, 3) };
            double TotalFare = invoiceGenerator.MultipleRides(rides);
            Console.WriteLine($"TotalFare : {TotalFare}");
        }
    }
}