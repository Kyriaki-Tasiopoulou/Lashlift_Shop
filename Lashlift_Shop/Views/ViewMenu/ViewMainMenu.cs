using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewMainMenu
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("Press 1 to Read All Lashlifters");
            Console.WriteLine("Press 2 to Read All Lashlifters with their Girls");
            Console.WriteLine("Press 3 to Read rich Lashlifters");
            Console.WriteLine("Press 4 to Read all Girls");
            Console.WriteLine("Press 5 to Create a new Lashlifter");
            Console.WriteLine("Press 6 to Create a new Girl");
            Console.WriteLine("Press 7 to Update a Lashlifter");
            Console.WriteLine("Press 8 to Update a Girl");
            Console.WriteLine("Press 9 to Delete a Lashlifter");            
            Console.WriteLine("Press 10 to Delete a Girl");            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 'E' to Exit Program");
            Console.ResetColor();
        }
    }
}
