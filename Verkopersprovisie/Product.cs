using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkopersprovisie
{
    class Product
    {
        private string name;
        private string productNumber;
        private double price;
        private int unitsSold;//
        private DateTime saleDate;

        public Product(string name, string productNumber, double price, int unitsSold, DateTime saleDate)
        {
            this.name = name;
            this.productNumber = productNumber;
            this.price = price;
            this.unitsSold = unitsSold;
            this.saleDate = saleDate;
        }

        public override string ToString()
        {
            return $"Name:{name}, Product Number:{productNumber}, Price:{price}, Amount:{unitsSold}, Sold:{saleDate.ToString("dd-MM-yyyy")}";
        }

        public string Name
        {
            get { return name; }
        }

        public string ProductNumber
        {
            get { return productNumber; }
            set { productNumber = value; }
        }

        public double Price
        {
            get { return price; }
        }

        public int UnitsSold
        {
            get { return unitsSold; }
            set { unitsSold = value; }
        }

        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }
    }
}
