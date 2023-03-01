using CabInvoiceGenerator;
using System.IO;

namespace CabInvcGenrtr_UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator UC-1!");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double fare = invoiceGenerator.CalculateFare(5.0, 3);
            Console.WriteLine($"Fare : {fare}");         
        }
    }
}