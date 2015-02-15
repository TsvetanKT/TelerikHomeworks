using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPerformance
{
    class TestingPerformance
    {
        static void Main()
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();
        
            //01. Using Entity Framework write a SQL query to select all employees from the Telerik Academy database 
            //  and later print their name, department and town. Try the both variants: with and without .Include(…). 
            //  Compare the number of executed SQL statements and the performance.

            Stopwatch sw = new Stopwatch();
            StringBuilder sb = new StringBuilder();

            sw.Start();
            foreach (var e in db.Employees)
            {
                // Printing to console so mush data seems useless.
                //Console.WriteLine("{0}{1}{2}", e.FirstName, e.Department, e.Address.Town);
                sb.AppendFormat("{0}{1}{2}", e.FirstName, e.Department, e.Address.Town);
            }

            sw.Stop();

            var elapsedWithoutInclude = sw.Elapsed;
            string resultWithoutInclude = sb.ToString();
            sb.Clear();
            sw.Reset();

            sw.Start();
            foreach (var e in db.Employees.Include("Address"))
            {
                //Console.WriteLine("{0}{1}{2}", e.FirstName, e.Department, e.Address.Town);
                sb.AppendFormat("{0}{1}{2}", e.FirstName, e.Department, e.Address.Town);
            }
            sw.Stop();

            string resultWithInclude = sb.ToString();
            var elapsedWithInclude = sw.Elapsed;

            Console.WriteLine("01.Time for executing the query:");
            Console.WriteLine("Without Include: " + elapsedWithoutInclude + "\nWith Include:    " + elapsedWithInclude+"\n");
            var timesFaster = elapsedWithoutInclude.TotalMilliseconds / elapsedWithInclude.TotalMilliseconds;
            Console.WriteLine("Using 'Include' makes this query " + timesFaster + " times faster.\n");

            Console.Write("Press Enter to Task02...");
            var stoped = Console.ReadLine();

            // 52 queries with Include and 373 without
            // In my case it's 21 times faster too.



            //02. Using Entity Framework write a query that selects all employees from the Telerik Academy
            //  database, then invokes ToList(), then selects their addresses, then invokes ToList(), then
            //  selects their towns, then invokes ToList() and finally checks whether the town is "Sofia".
            //  Rewrite the same in more optimized way and compare the performance.


            IEnumerable query = db.Employees.ToList()
                .Select(x => x.Address).ToList()
                .Select(t => t.Town).ToList()
                .Where(t => t.Name == "Sofia");
            foreach (var t in query)
            {
                // Total of 1292 queries
                Console.WriteLine(t);
            }

            IEnumerable querySmart = db
                .Employees.Select(x => x.Address)
                .Select(t => t.Town)
                .Where(t => t.Name == "Sofia")
                .ToList();

            foreach (var t in querySmart)
            {
                // Total of 2 queries
                Console.WriteLine(t);
            } 
        }
    }
}
