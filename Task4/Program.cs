using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(0, " ", " ", " ", 5, 10);
            Console.WriteLine("Price without NDS: {0}\nPrice with NDS: {1}", 
                invoice.PriceWithoutNDSCalculate(), invoice.PriceWithNDSCalculate(0.2));
        }
    }
}
