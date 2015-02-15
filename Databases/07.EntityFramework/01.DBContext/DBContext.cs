namespace DBContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UsingEFModel;


    class DBContext
    {

        static void Main()
        {
            Console.WriteLine("/01.Using the Visual Studio Entity Framework designer\n create a DbContext for the Northwind database\n");
            using (var db = new NorthwindEntities())
            {
                var country = "Mexico";
                Console.WriteLine("Customers from " + country +":");
                foreach (var customer  in db.Customers.Where(x => x.Country == country))
                {
                    Console.WriteLine(customer.ContactName);
                }
            }

            Console.WriteLine("\n03.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.\n");

            // I have some hardware problems so i must send this unfinished homework.
        }

        public static List<string> CustomersWithOrdersFromYearToPlace(int year, string place)
        {
            var customers = new List<string>();
            using (var db = new NorthwindEntities())
            {
                //var custSuppl =
                //    from customer in db.Customers
                //    join order in db.Orders
                //    where order.RequiredDate == year
                //    where order.ShipCountry == palce
                    
                //    select new
                //    {
                //        CustomerName = customer.CompanyName,
                //        Supplier = order.CompanyName,
                //        Country = customer.Country
                //    };
 
            }
            return customers;
        }
    }
}
