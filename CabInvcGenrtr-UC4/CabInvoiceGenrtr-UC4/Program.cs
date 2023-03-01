using CabInvoiceGenerator;

namespace CabInvoiceGenrtr_UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator UC-4!");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(2.0, 5), new Ride(1.0, 3) };
            double TotalFare = invoiceGenerator.MultipleRides(rides);
            Console.WriteLine($"TotalFare : {TotalFare}");
        }
    }
}