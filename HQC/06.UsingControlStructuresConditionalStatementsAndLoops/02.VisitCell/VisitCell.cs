namespace Chef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestIf
    {
        public static void Main()
        {
            const int MIN_X = 0;
            const int MAX_X = 7;

            const int MIN_Y = 10;
            const int MAX_Y = 17;

            int x = 1;
            int y = 11;

            bool shouldVisitCell = true;
            bool xIsInRange = MAX_X >= x && x >= MIN_X;
            bool yIsInRange = MAX_Y >= y && y >= MIN_Y;

            // if x and y are in range and if the cell must be visited -> then we are visiting the cell
            if (shouldVisitCell && xIsInRange && yIsInRange)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("The cell has been visited.");
        }
    }
}
