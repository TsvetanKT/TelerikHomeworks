using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficientlyFindInRange
{
    public class Product : IComparable
    {
        public Product()
        {

        }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price - ((Product)obj).Price;
        }
    }
}
