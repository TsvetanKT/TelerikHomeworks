namespace Chef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChefTest
    {
        public static void Main()
        {
            Chef chef = new Chef();

            Potato potato = new Potato();
            potato.IsRotten = false;

            if (potato != null)
            {
                if (!potato.IsRotten)
                {
                    chef.Cook(potato);
                    Console.WriteLine("Potato is cooked!");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The potato is rotten, cannot cook!");
                }
            }
            else
            {
                throw new ArgumentNullException("There is no potato!");
            }
        }
    }
}
