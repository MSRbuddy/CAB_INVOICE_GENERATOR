using CabInvoiceGenerator;

namespace CabInvcGenrtr_UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome tpo Cab Invoice Generator UC-3!");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(2.0, 5), new Ride(1.0, 3) };
            double TotalFare = invoiceGenerator.MultipleRides(rides);
            Console.WriteLine($"TotalFare : {TotalFare}");
        }
    }
}