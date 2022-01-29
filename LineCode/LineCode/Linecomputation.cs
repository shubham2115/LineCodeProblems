using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCode
{
    public class Linecomputation
    {

      
            public void Comparision()
            {
                Console.WriteLine("Enter co-ordinates for (x1,y1): ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter co-ordinates for (x1,y1): ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());

                double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                Console.WriteLine("The length of the line is: " + length);
                Console.ReadLine();
            }
        
    }
}
