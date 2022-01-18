using System;

namespace HW13
{
    class Converter 
    {
        private double USD;
        private double EUR;
        private double RUB;
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public double ConvertFromUAH(double money, string currency)
        {
            switch (currency)
            {
                case "usd":
                    return money / USD;
                case "eur":
                    return money / EUR;
                case "rub":
                    return money / RUB;
                default:
                    Console.WriteLine("Incorrect currency");
                    return 0;
            }
        }
        public double ConvertToUAH(double money, string currency)
        {
            switch (currency)
            {
                case "usd":
                    return money * USD;
                case "eur":
                    return money * EUR;
                case "rub":
                    return money * RUB;
                default:
                    Console.WriteLine("Incorrect currency");
                    return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(28, 32, 0.37);
            Console.WriteLine(converter.ConvertFromUAH(1000, "usd"));
            Console.WriteLine(converter.ConvertToUAH(100,"eur"));
        }
    }
}
