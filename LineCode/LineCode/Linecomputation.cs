using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCode
{
    public class Linecomputation
    {


        public void LineComparision()
        {
            Console.WriteLine("Enter co-ordinates for (x1,y1): ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter co-ordinates for (x1,y1): ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter co-ordinates for (x3,y3): ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter co-ordinates for (x4,y4): ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());



            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double length2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("The length of the line is: " + length1 +length2);

            if (length1 == length2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are unequal");
            }
               
            Console.ReadLine();
        }

    }
}
