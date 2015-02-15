namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Product
    {
        public Product(string name, int cost, int weight)
        {
            this.Name = name;
            this.Price = cost;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }
    }
}
