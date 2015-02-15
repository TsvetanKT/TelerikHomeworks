using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingEFModel;

namespace EntityFrameworkHW
{
    //02. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. Write a testing class.

    public class FuncForInsertModDelCustomers

    {

        static void Main()
        {
            Console.WriteLine("02.Program started.");

            // The program doesnt work cuz the wierd Id-s
            
            //string newCustomer = CreateNewCustomer("Joe", "Joko");
            //Console.WriteLine("Created new customer.");
            //Console.WriteLine(newCustomer);

        }

        public static string CreateNewCustomer(string customertName, string contactName)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer newCustomer = new Customer
            {
                CompanyName = customertName,
                ContactName = contactName,
            };
            northwindEntities.Customers.Add(newCustomer);
            northwindEntities.SaveChanges();
            return newCustomer.CustomerID;
        }

        public static void ModifyCustomertName(string customerId, string newName)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            customer.ContactName = newName;
            northwindEntities.SaveChanges();
        }

        public static void DeleteCustomer(string customerId)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            northwindEntities.Customers.Remove(customer);
            northwindEntities.SaveChanges();
        }

        public static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerId)
        {
            Customer customer = northwindEntities.Customers.FirstOrDefault(
                c => c.CustomerID == customerId);
            return customer;
        }
    }
}
