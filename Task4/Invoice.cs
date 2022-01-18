using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Invoice
    {
        public readonly int _account;
        public readonly string _customer;
        public readonly string _provider;
        private string _article;
        private int _quantity;
        public double _price;
        public Invoice(int account, string customer, string provider, string article, int quantity, double price)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
            _article = article;
            _quantity = quantity;
            _price = price;
        }
        public double PriceWithoutNDSCalculate()
        {
            return _price * _quantity;
        }
        public double PriceWithNDSCalculate(double NDS)
        {
            return _price * _quantity * (1 + NDS);
        }
    }
}